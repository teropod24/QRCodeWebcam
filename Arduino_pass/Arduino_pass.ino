#include <Wire.h>
#include <LCD.h>
#include <LiquidCrystal_I2C.h>
#include <Keypad.h>

// Configuración del password y variables necesarias
char valid_pass[10] = ""; // El password correcto (recibido de C#)
int contador = 30;
int num_caracteres = 0;
char contrasena[10] = ""; // Array para almacenar el password ingresado
unsigned long lastMillis = 0;
bool passwordValido = false;
bool programaIniciado = false; // Bandera para iniciar el programa desde C#
byte INDICE = 0;

const byte rows = 4;
const byte cols = 4;

char keyMap[rows][cols] = {
  {'1', '2', '3', 'A'},
  {'4', '5', '6', 'B'},
  {'7', '8', '9', 'C'},
  {'*', '0', '#', 'D'}
};

byte rowPins[rows] = {9, 8, 7, 6};
byte colPins[cols] = {5, 4, 3, 2};

Keypad myKeypad = Keypad(makeKeymap(keyMap), rowPins, colPins, rows, cols);
LiquidCrystal_I2C lcd(0x27, 2, 1, 0, 4, 5, 6, 7);

void setup() {
  Serial.begin(9600);
  Serial.println("Esperando comando de inicio...");

  lcd.setBacklightPin(3, POSITIVE);
  lcd.setBacklight(HIGH);
  lcd.begin(16, 2);
}

void loop() {
  // Verifica si el programa ha recibido el comando de inicio
  if (!programaIniciado) {
    if (Serial.available() > 0) {
      char comando = Serial.read();
      if (comando == 'S') {
        programaIniciado = true;
        Serial.println("Comando de inicio recibido. Iniciando programa...");
        lcd.setCursor(0, 1);
        lcd.print("contador:");
        lcd.print(contador);
      }
    }
    return; // Espera hasta recibir el comando de inicio
  }

  unsigned long currentMillis = millis();

  // Actualización del contador si el password es incorrecto
  if (!passwordValido && currentMillis - lastMillis >= 1000) {
    lastMillis = currentMillis;
    contador--;
    lcd.setCursor(9, 1);
    lcd.print("   "); // Limpia el espacio del contador
    lcd.setCursor(9, 1);
    lcd.print(contador);

    if (contador <= 0) {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Tiempo OFF");
      while (1); // Detiene el programa
    }
  }

  // Solicitud de ingreso de password
  lcd.setCursor(0, 0);
  lcd.print("Pass: ");
  char whichKey = myKeypad.getKey();

  if (whichKey) {

    if (whichKey == 'A') {
      if (num_caracteres > 0) {
        num_caracteres--;
        lcd.setCursor(num_caracteres + 6, 0);
        lcd.print(" ");
        INDICE--;
        contrasena[INDICE] = '\0'; // Eliminar el último carácter
      }

    // Borrar toda la contraseña si se presiona 'B'
    } else if (whichKey == 'B') {
      lcd.setCursor(6, 0);
      lcd.print("         "); // Borra los caracteres de la pantalla
      num_caracteres = 0;
      INDICE = 0;
      memset(contrasena, 0, sizeof(contrasena)); // Reinicia la contraseña

    // Comparar contraseña si se presiona '#'
    } else if (whichKey == '#') {
      if (!strcmp(contrasena, valid_pass) == 0) {
        passwordValido = true;
        lcd.clear();
        lcd.setCursor(0, 0);
        lcd.print("CORRECT"); // Contraseña correcta
        lcd.setCursor(0, 1);
        lcd.print(" ");
        Serial.println(String(contrasena) + ":true");
        while (1);
      } else {
        lcd.clear();
        lcd.setCursor(0, 0);
        lcd.print("NOK CORRECT"); // Contraseña incorrecta
        delay(1000); // Mostrar "NOK" por un segundo
        lcd.clear();
        lcd.setCursor(0, 1);
        lcd.print("contador:");
        lcd.setCursor(9, 1);
        lcd.print(contador);
        Serial.println(String(contrasena) + ":false");
      }
      num_caracteres = 0;
      INDICE = 0;
      memset(contrasena, 0, sizeof(contrasena)); // Reiniciar contraseña después de la comparación

    // Ingreso de un número
    } else {
      if (isDigit(whichKey)) {
        if (num_caracteres < 10) {
          contrasena[INDICE] = whichKey;
          INDICE++;
          num_caracteres++;
          lcd.setCursor(num_caracteres + 5, 0);
          lcd.print("*");
        }
      }
    }
  }
}
