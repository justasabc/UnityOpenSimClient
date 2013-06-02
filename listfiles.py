'''put this script into character and openmetaverse_data folders and execute it 
to get manifest.txt listing all the files in this folder. manifest.txt is used 
for UnityClient.cs to install thoses 2 folders on android'''


import os

if __name__ == "__main__":
	f = open("manifest.txt", "w")
	for path, subpaths, files in os.walk('.'):
		p = path[2:]	#remove .\
		if len(p) > 0:
			for fname in files:
				if fname[-5:] != ".meta":
					f.write(p + '/' + fname + '\n')
		else: #len(p)==0
			for fname in files:
				if fname != "listfiles.py" and fname != "manifest.txt" and fname[-5:] != ".meta":
					f.write(fname + '\n')
	f.close()
		
