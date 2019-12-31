import random as r

def summation(weights, inputs):
    s = 0
    for i in range(len(inputs) - 1):
        s = s + (weights[i] * inputs[i])
    total = s + weights[-1]
    if(total >= 0):
        return 1
    else:
        return -1

def program():
    inputs = [-1, 2, 0, -4, 1]
    weights = []
    classi = -1

    for i in range(5):
        a = int(r.uniform(-4, 4))
        weights.append(a)

    print("Inputs = ", inputs)
    print("Weights = ", weights)
    print("Classi = ", classi)

    Misclassed = False
    while(Misclassed != True):
        for i in range(len(inputs)):
            CalcClass = summation(weights,inputs)
            print("CalcClass = ", CalcClass)
            if(CalcClass == classi):
                print("Perfect Weights are = ", weights)
                break
            else:
                print("New Weights")
                for j in range(len(weights)):
                    weights[j] = weights[j] + (classi * inputs[j])
                    print("W", [j]," = ", weights[j])
    Misclassed = True

program()