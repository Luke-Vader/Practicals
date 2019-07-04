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
