#Reading the csv data into the data variable
data<-read.csv("salary.csv")

#using simple ggplot to get the plane and saving it into the variable plot 
plot = ggplot(data, aes(x = Heads, y = Salary))

#we are use the variable plot to modify and concatenate the graph to our requirements
#for example the following will give the points a red colour and their radius will be set to 5
plot + geom_point(aes(colour = 'red', size =5))

#this gives us a bar graph with the current available data
plot + geom_bar(stat = 'identity')

#we can get the line graph for the data with the followng function
plot + geom_line(stat = 'identity', aes(group = 1, colour = 'red'))

#Adding a title to the whole plot is this:
plot<- plot + ggtitle(label = 'Expenses')
