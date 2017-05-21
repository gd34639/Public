#!/usr/bin/python
print ("Hello gd34639\nPrzykład klasy pozycja w Pythonie class Pozycja\n")

class Pozycja:
  """Klasa przechowująca pozycję figury"""
  x = 0
  y = 0

  def __init__(self, pole):
    self.ustaw(pole)
   
  def ustaw(self, pole):
    self.x = ord(pole[0]) - ord('A') + 1
    self.y = int(pole[1])
