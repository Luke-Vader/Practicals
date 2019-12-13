import random

head="Round\tM/c\tUser\tWinner\n"

file=open('score.txt','w')
file.write(head)
file.close()

def fetchinput(count):
   x=count
   f=open('score.txt','a+')
   a=int(input("Enter 1 for Rock, 2 for Paper and 3 for Scissors."))
   b=random.randint(1,3)
   if a==b:
      print("Tie")
      f.write("%d\tRock\tRock\tTie\n"%x)
      return 2
   if a==1:
      if b==2:
         print("Computer wins")
         f.write("%d\tPaper\tRock\tMachine\n"%x)
         return 0

      if b==3:
         print("User wins")
         f.write("%d\tSciss\tRock\tUser\n"%x)
         return 1
   if a==2:
      if b==3:
         print("Computer wins")
         f.write("%d\tSciss\tPaper\tComputer\n"%x)
         return 0

      if b==1:
         print("User Wins")
         f.write("%d\tRock\tPaper\tUser\n"%x)
         return 1

   if a==3:
      if b==2:
         print("User Wins")
         f.write("%d\tPaper\tSciss\tUser\n"%x)
         return 1

      if b==1:
         print("Computer Wins")
         f.write("%d\tRock\tSciss\tComputer\n"%x)
         return 0
flag=0
pc=0
user=0
while flag<5:
   flag=flag+1
   c=fetchinput(flag)
   if c==1:
      user=user+1
   if c==0:
      pc=pc+1

if user>pc:
   print("You win")
else:
   print("Machine Wins")
   
f=open('score.txt','r')
if f.mode == 'r':
   contents=f.read()
   print(contents)
file.close()
