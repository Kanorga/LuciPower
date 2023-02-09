#define POWER_PIN 8
#define BUTTON_PIN 7

void setup() {
  pinMode(POWER_PIN, OUTPUT);
  pinMode(BUTTON_PIN, INPUT);
}

void loop() {
  if (digitalRead(BUTTON_PIN) == HIGH) {
    digitalWrite(POWER_PIN, HIGH);
  }
  else {
    digitalWrite(POWER_PIN, LOW);
  }
}
