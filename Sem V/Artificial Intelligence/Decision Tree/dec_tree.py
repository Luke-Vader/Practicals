def createTree(a, b):
    print("a and b are incoming values")

def classify(a, b, c):
    print("inside classify function")
    
#build a tree
mytree = createTree(myDat, labels)
print(mytree)

print("Thanks, now I can recognize winter family photo, give me any photo")

#run test

# test with winter family photo
answer = classify(mytree, ['cartoon', 'winter', 'more than 1 person'], [0, 1, 1])
print("Hi, the answer is "+ answer + ", it is winter family photo")

# test with cartoon characters winter pictures
answer = classify(mytree, ['cartoon', 'winter', 'more than 1 person'], [1, 1, 1])
print("Hi, the answer is "+ answer + ", it is not winter family photo")