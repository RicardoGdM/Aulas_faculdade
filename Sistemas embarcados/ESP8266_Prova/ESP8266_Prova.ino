/**
   Instalar Bibliotecas:
    
    * ArduinoHttpCliente
    by Arduino Versão 0.6.1 [EXPERIMENTAL]

    * ArduinoJson
    by Benoit Blanchon Versão 7.3.1

    --- Se acontecer de alguma das abaixo não estar diponivel, pule para a próxima.

    * Ethernet
    Built-In by Arduino Versão 2.00
    
    * WiFi
    Built-In Arduino Versão 1.2.7

    * WiFiManager
    by tablatronix Versão 2.0.17

    * OneWireNoResistor_ESP8266
    by Drive do Professor!!
   
*/

#include <Arduino.h>

#include <ESP8266WiFi.h>
#include <ESP8266WiFiMulti.h>
#include <ESP8266HTTPClient.h>
#include <WiFiClient.h>
#include <ArduinoJson.h>

#include "OneWire.h"
#include "DallasTemperature.h"

#define ONE_WIRE_BUS 4

#include <DHT11.h>

DHT11 dht11(4);      // Pino onde o DHT11 está conectado (GPIO2 - D4 no NodeMCU)
#define DHTTYPE DHT11 // Tipo do sensor DHT

#include <deque>

OneWire oneWire(ONE_WIRE_BUS);
DallasTemperature sensors(&oneWire);

ESP8266WiFiMulti WiFiMulti;

const char* ssid = "ACADEMICA";//SSID
const char* password = "WIFI@Academico";//SENHA
//const char* serverUrl = "http://web-ebytes.duckdns.org:86/esp/set"; // Endereço da sua API
const char* serverGrupoUrl = "http://web-ebytes.duckdns.org:86/esp/group"; //mac, ip, local
const char* serverAlunoUrl = "http://web-ebytes.duckdns.org:86/esp/aluno"; //nomes
const char* serverSensorUrl = "http://web-ebytes.duckdns.org:86/esp/set"; //dados do servidor
float sorteio;
int grupoID;

// Estrutura para guardar dados pendentes
struct DadosSensor {
  String sensor;
  String nome;
  String valor;
  int grupoID;
};

std::deque<DadosSensor> cache; // Cache FIFO de envio pendente

void setup() {
  digitalWrite(4, HIGH);
  pinMode(4, INPUT_PULLUP);
  Serial.begin(115200);
  Serial.println("\nIniciando...");

  WiFi.mode(WIFI_STA);
  WiFiMulti.addAP(ssid, password);

  while (WiFiMulti.run() != WL_CONNECTED) {
    Serial.println("Tentando conectar ao WiFi...");
    delay(1000);
  }

  Serial.println("WiFi conectado!");
  Serial.print("Endereço IP: ");
  Serial.println(WiFi.localIP());

  // --- Criando dados do grupo
  StaticJsonDocument<200> jsonGrupo;
  jsonGrupo["nome"] = "Laboratório 4";
  jsonGrupo["ip"] = WiFi.localIP().toString();
  jsonGrupo["mac"] = WiFi.macAddress();

  // --- Criando dados dos alunos
  DynamicJsonDocument jsonAluno(1024);
  JsonArray alunos = jsonAluno.createNestedArray("alunos");

  JsonObject aluno1 = alunos.createNestedObject();
  aluno1["nome"] = "Eduardo Henrique Degan";
  aluno1["semestre"] = "6";

  JsonObject aluno2 = alunos.createNestedObject();
  aluno2["nome"] = "Ricardo Gomes de Moraes";
  aluno2["semestre"] = "6";

  // --- Loop até grupo ser criado com sucesso
  while (grupoID <= 0) {
    Serial.println("[HTTP] Enviando dados do grupo...");

    WiFiClient client;
    HTTPClient http;

    if (http.begin(client, serverGrupoUrl)) {
      http.addHeader("Content-Type", "application/json");

      String jsonStringGrupo;
      serializeJson(jsonGrupo, jsonStringGrupo);
      int httpResponseCodeGrupo = http.POST(jsonStringGrupo);

      if (httpResponseCodeGrupo > 0) {
        String response = http.getString();
        Serial.println("Resposta do servidor (Grupo):");
        Serial.println(response);

        StaticJsonDocument<200> jsonResp;
        DeserializationError error = deserializeJson(jsonResp, response);

        if (!error && jsonResp.containsKey("grupoID")) {
          grupoID = jsonResp["grupoID"];
          jsonAluno["grupoID"] = grupoID;
          Serial.print("Grupo ID obtido com sucesso: ");
          Serial.println(grupoID);
          Serial.println();
          Serial.println();
          Serial.println();
          delay(5000);
          Serial.println("Acesse seu Dashboard no link abaixo: ");
          Serial.print("http://web-ebytes.duckdns.org:86/esp/grupo/");
          Serial.println(grupoID);
          Serial.println();
          Serial.println();
          Serial.println();
          delay(5000);
        } else {
          Serial.println("Erro ao obter grupoID. Tentando novamente em 5s...");
          delay(5000);
        }
      } else {
        Serial.print("Erro HTTP grupo: ");
        Serial.println(httpResponseCodeGrupo);
        delay(5000);
      }

      http.end();
    } else {
      Serial.println("Erro ao conectar com o servidor (Grupo). Tentando novamente...");
      delay(5000);
    }
  }

  // --- Loop até alunos serem cadastrados com sucesso
  bool alunosEnviados = false;

  while (!alunosEnviados) {
    WiFiClient client;
    HTTPClient http;

    if (http.begin(client, serverAlunoUrl)) {
      http.addHeader("Content-Type", "application/json");

      String jsonStringAluno;
      serializeJson(jsonAluno, jsonStringAluno);
      int httpResponseCodeAluno = http.POST(jsonStringAluno);

      if (httpResponseCodeAluno > 0) {
        String responseAluno = http.getString();
        Serial.println("Resposta do servidor (Aluno):");
        Serial.println(responseAluno);

        if (responseAluno.indexOf("sucesso") != -1 || responseAluno.indexOf("parcial") != -1) {
          alunosEnviados = true;
          Serial.println("Alunos enviados com sucesso!");
        } else {
          Serial.println("Erro na resposta dos alunos. Tentando novamente em 5s...");
          delay(5000);
        }
      } else {
        Serial.print("Erro HTTP aluno: ");
        Serial.println(httpResponseCodeAluno);
        delay(5000);
      }

      http.end();
    } else {
      Serial.println("Erro ao conectar com o servidor (Aluno). Tentando novamente...");
      delay(5000);
    }
  }

  Serial.println("Cadastro inicial concluído! Entrando no loop principal...");
}

void loop() {
  float tempC;
  int numberOfDevices;
  DeviceAddress tempDeviceAddress;

  int tempRecente, tempAtual;
  int umidadeRecente, umidadeAtual;

  numberOfDevices = sensors.getDeviceCount();
  sensors.requestTemperatures();

  int result = dht11.readTemperatureHumidity(tempAtual, umidadeAtual);

  if ((WiFiMulti.run() == WL_CONNECTED)) {

    DadosSensor dados;
    dados.grupoID = grupoID;

    if (tempAtual != tempRecente){
      tempRecente = tempAtual;
      dados.sensor = "DHT11";
      dados.nome = "Temperatura";
      dados.valor = tempRecente;

      cache.push_back(dados); // Adiciona ao final do cache
    }
      
    if (umidadeAtual != umidadeRecente){
      umidadeRecente = umidadeAtual;
      dados.sensor = "DHT11";
      dados.nome = "Umidade";
      dados.valor = umidadeRecente;

      cache.push_back(dados); // Adiciona ao final do cache
    }

    

    // Tenta enviar o primeiro item do cache
    if (!cache.empty()) {
      WiFiClient client;
      HTTPClient http;
      if (http.begin(client, serverSensorUrl)) {
        http.addHeader("Content-Type", "application/json");

        StaticJsonDocument<200> jsonDoc;
        jsonDoc["sensor"] = cache.front().sensor;
        jsonDoc["nome"] = cache.front().nome;
        jsonDoc["valor"] = cache.front().valor;
        jsonDoc["grupoid"] = cache.front().grupoID;

        String jsonString;
        serializeJson(jsonDoc, jsonString);

        int httpResponseCode = http.POST(jsonString);
        if (httpResponseCode > 0) {
          Serial.println("Dado enviado com sucesso!");
          Serial.println(http.getString());
          cache.pop_front(); // Remove do cache
        } else {
          Serial.print("Erro ao enviar, mantendo no cache: ");
          Serial.println(httpResponseCode);
        }
        http.end();
      }
    }

  } else {
    Serial.println("WiFi desconectado, tentando reconectar...");
  }

  delay(5000); // pode ajustar conforme necessário
}
