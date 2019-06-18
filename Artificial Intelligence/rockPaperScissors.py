import random
import os

user_score = 0
machine_score = 0
keepGoing = "Y"

while keepGoing != "N":
    print("Lets Play\n1. Rock\n2. Paper\n3. Scissor\n")
    machine = random.randint(1,3)
    user = int(input())
    if machine == 1:
        if user == 2:
            user_score = user_score + 1
        elif user == 3:
            machine_score = machine_score + 1
    elif machine == 2:
        if user == 1:
            machine_score = machine_score + 1
        elif user == 3:
            user_score = user_score + 1
    elif machine == 3:
        if user == 1:
            user_score = user_score + 1
        elif user == 2:
            machine_score = machine_score + 1
    elif machine == user:
        draw = 1
    print("Machine: ",machine_score,"\tUser: ",user_score)
    keepGoing = input("Do you want to continue (Y/N): ")
    os.system('cls')

if machine > user:
    print("Machine Won with ",machine_score)
elif machine == user:
    print("Perfect Balance")
elif machine < user:
    print("User Won, there is still hope ",user_score)
