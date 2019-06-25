#importing tkinter package
from tkinter import*

#importing tkinter messagebox package
import tkinter.messagebox as box

#initializing window variable
window = Tk()

#START is the window title now
window.title("START")

#we make a frame thingy which is inflated into the window
frame = Frame(window)

#we make an object similar to a TextView
label = Label(frame, text = "Give me an Object")

#setting the frame to the entry variable through the Entry constructor like a EditText
entry = Entry(frame)

#
def dialog():
    box.showinfo('Open', 'Shit '+entry.get()+' you so DEAD')

btn = Button(frame, text = "Click Me", command = dialog)

'''
label.pack(side = LEFT)
entry.pack(side = RIGHT)
btn.pack(side = BOTTOM)
'''

label.grid(row = 0)
entry.grid(row = 0, column = 1)
btn.grid(row = 1, column = 3)

frame.pack(padx = 40, pady = 50)

window.mainloop()
