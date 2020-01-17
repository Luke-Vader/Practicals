#Imports the data from mongoDB
data = mongo(collection = "crime", db = "admin")

#This function gives us all the crimes for all valid dates
filter = data$find('{"Domestic" : "TRUE"}', fields = '{"Date" : 1, "Domestic" : 1}')

#This function part of the lubridate library changes the format of the date from whatever current formate
# to the hour minute second format
filter$Date = mdy_hms(filter$Date)