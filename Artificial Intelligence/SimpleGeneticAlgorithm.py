import random as r
import statistics as s

w1 = [31, 30, 24, 29, 30, 32, 31]
w2 = [30, 29, 29, 28, 27, 29, 30]

print("Generation 0\n")
print("w1 = ", w1, "\nw2 = ", w2)

avg_w1 = s.mean(w1)
avg_w2 = s.mean(w2)

print("Fitness value of w1 = ", avg_w1, "\n Fitness value of w2 = ", avg_w2)
gen = (avg_w1 + avg_w2)
print("Fitness Function = ", gen)

opt_val = 0
count = 1

while(gen != opt_val):
    print("Generation ", count)
    gen = opt_val
    print("Parent 1: ", w1, "Parent 2: ", w2)
    a = r.randrange(7)
    print("\nCrossover Point = ", a)
    w1[a:], w2[a:] = w2[a:], w1[a:]
    print("Fitness value of Previous Generation = ", gen)

    select  = w1
    choice = w1.index(choice)
    w1[ind] = r.randrange(25,35)

    print("After Mutation\nLocation of Mutation: ", ind, "\noff1 = ", w1, "\toff2 = ", w2)

    avg_off1 = s.mean(w1)
    avg_off2 = s.mean(w2)

    print("Individual Fitness Value of offspring1 = ", avg_off1, "\nIndividual Fitness Value of offspring2 = ", avg_off2)

    opt_val = (avg_off1 + avg_off2)/2

    print("Opt fit value for this generation = ", opt_val)
    count = count + 1