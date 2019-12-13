library(ggplot2)
library(dplyr)
library(maps)
library(ggmap)
library(mongolite)
library(lubridate)
library(gridExtra)

#the data is take from mongoDB database and the object is also on mongoDB
#it is being accessed by R from mongoDB
data=mongo(collection = "crimes", db = "rishabh")

#this shoes hoe many rows of data we have
data$count()

#Identify different attributes
#to display one row we get the attributes present
data$iterate()$one()

#Identify distinct values of each attribute
#you can get each attribute's distinct values by using the distinct() with the column name
data$distinct("Description")

#Find the total number of instances
#the inbuilt count function gives us the number of rows
data$count()

#Extract set of data from entire set
#this is like writing a query for the data present in mongoDB
data$find('{"Primary Type":"ASSAULT"}') #this will get everything from ASSAULT Primary Type

#top 10 locations of max crime
#this would take all the locations and count the number of crimes occurring in each location 
data$aggregate('[{"$group":{"_id":"$Location Description", "Count": {"$sum":1}}}]')

#now we need it in descending order so we use order
topLocations = locationCrime[order(-locationCrime$Count),]

#then we have our data sorted in descending order of crime but we need only top 10 locations
topLocations = head(topLocations,10)

#We put this in a pie chart now
pie(topLocations$Count, labels = topLocations$`_id`)

#fora a fancier pie you an always go for 
pie3D(topLocations$Count, labels = topLocations$`_id`)