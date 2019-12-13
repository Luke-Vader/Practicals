#Data set creation with a function
def createDataSet():
    dataSet = [[0, 1, 1, 'yes'],
               [0, 1, 0, 'no'],
               [1, 0, 1, 'no'],
               [1, 1, 1, 'no'],
               [0, 1, 0, 'no'],
               [0, 0, 1, 'no'],
               [1, 0, 1, 'no'],
               [1, 1, 0, 'no']]
    labels = ['cartoon', 'winter', 'more than 1 person']
    # change to discrete values
    return dataSet, labels

#Create data set
myDat, labels = createDataSet()

#Build a tree
myTree = createTree(myDat, labels)
print(mytree)

print(" is happenning")
