db=1
while db<=5:
  try:
    alap=int(input("Alap: "))
    ado=int(input("Adó: "))
    if ado/alap<=.27:
      print("O.K.")
    else:
      print("nem jó")  
  except:
    print("ne jó, de nem úgy")
  db+=1
