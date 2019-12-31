library(party)

data = iris

ctree(Species~.,data)

input.dat = data
output.tree <- ctree(Species~., data = input.dat)
plot(output.tree)