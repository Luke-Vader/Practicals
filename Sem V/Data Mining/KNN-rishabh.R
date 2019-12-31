In regression  we will find the relation between an independent and a dependent variable
byx means y is dependent on x. You know the formula

a = iris[1:5,]
b = iris[51:55,]
c = iris[101:104,]
TData = rbind(a,b,c)

TData = as.data.frame(scale(iris[,-5]))
TData$class = iris$species
install.packages("caret")
install.packages("e1071")
library(caret)
library(e1071)
model = train (class~.,data = TData,method = "knn")
t = data
predict(model,t)

model = naiveBayes(class~., data = TData)
t = data.frame(Sepal.Length = 5.9, Sepal.Width = 3.0, Petal.Length = 5.1, Petal.Width = 1.8)
predict(model,t)

model = knn(Training_data[,-5],Test_data[,-5],Training_data[,5],k=9)
