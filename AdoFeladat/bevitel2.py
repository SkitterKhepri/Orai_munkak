import random


while(True):
	try:
		alap = int(input("Alap: "))
		ado = int(input("Adó: "))
		break
		
	except:
		pass


if (ado/alap > 0.27):
	print("Lehetetlen adatok!")
	
elif (ado/alap == 0):
	print(f"Az egész alap({alap}) 0%-os kulcsú")
	
elif (ado/alap == 0.05):
	print(f"Az egész alap({alap}) 0.05%-os kulcsú")
	
elif (ado/alap == 0.18):
	print(f"Az egész alap({alap}) 0.18%-os uklcsú")
	
elif (ado/alap == 0.27):
	print(f"Az egész alap({alap}) 0.27%-os kulcsú")

else:
	x1 = 0
	x2 = 0
	x3 = 0
	x4 = 0
	while ((x2*0.05) + (x3*0.18) + (x4*0.27) != ado):
		x1 = random.randint(0, alap)
		if (x1 == alap):
				continue
		x2 = random.randint(0, alap - x1 - 1)
		x3 = random.randint(0, alap - x1 - x2 - 1)
		x4 = random.randint(0, alap - x1 - x2 -x3 - 1)
	
	if (x1 + x2 + x3 + x4 != alap):
		
		x1 += (alap - x1 - x2 - x3 - x4)
		
	
	print(f"0%: {x1} adó: {x1*0}\n5%: {x2} adó: {x2*0.05}\n18%: {x3} adó: {x3*0.18}\n27%: {x4} adó: {x4*0.27}")
		
