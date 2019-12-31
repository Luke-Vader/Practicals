from math import log
import operator
#---------------------------------------------------
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
#---------------------------------------------------
def majorityCnt(classList):
    classCount = {}

    print("classCount",classCount)
    for vote in classList:
        if vote not in classCount.keys(): classCount[vote] = 0
        classCount[vote] += 1
    sortedClassCount = sorted(classCount.items(), key=operator.itemgetter(1), reverse=True)
    return sortedClassCount[0][0]
#---------------------------------------
def createTree(dataSet, labels):
    # extracting data of the goal column using example[-1]
    classList = [example[-1] for example in dataSet]
    #print(classList[0])
    print("classList is a follows=\n",classList)
    '''
    print("\nclassList[0]",classList[0])#yes
print("len(classList)=",len(classList))  #8 samples
    print("classList.count(classList[0])=",classList.count(classList[0]))  #1
    
    print(classList.count(classList[0]) == len(classList)) #false'''

    # elseif all ex have same classification then return it
    
    if classList.count(classList[0]) == len(classList):
        return classList[0]  # stop splitting when all of the classes are equal

    #elseif attributes empty then return MajVal(ex)

    print("len(dataSet[0])=",len(dataSet[0])) #4 (4 columns as features)

   # print("dataSet[0][1]=",dataSet[0][1]) # row and column
     
    if len(dataSet[0]) == 1:  # stop splitting when there are no more features in dataSet
        return majorityCnt(classList)

    # else ChooseAttribute(attr,ex) -> best1
    #    new decision tree with root test best1 -> tree1

    
    
#-----------------------------------------------------------   
# collect data
myDat, labels = createDataSet()

print("Data set for training along with labels was collected")

#build a tree
mytree = createTree(myDat, labels)
print(mytree)

classList = [example[-1] for example in myDat]
print("Majority count is as follows:")
majorityCnt(classList)
