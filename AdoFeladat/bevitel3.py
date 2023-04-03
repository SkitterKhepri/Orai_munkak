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
	
	f = open("eredmenyek.txt", "w")
	
	for x1 in range(alap + 1):
		for x2 in range(alap + 1):
			for x3 in range(alap + 1):
				for x4 in range(alap + 1):
					
					feltetel1 = alap == x1 + x2 + x3 + x4
					feltetel2 = ado == 0.05*x2 + 0.18*x3 + 0.27*x4
					
					if (feltetel1 & feltetel2):
						
						print(f"0%: {x1} adó: {x1*0}\n5%: {x2} adó: {x2*0.05}\n18%: {x3} adó: {x3*0.18}\n27%: {x4} adó: {x4*0.27}", file = f)
						print("-"*25, file = f)
						
						
	f.close()


