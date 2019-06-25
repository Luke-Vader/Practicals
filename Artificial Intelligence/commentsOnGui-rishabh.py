#importing tkinter package
from tkinter import*

#importing tkinter messagebox package
import tkinter.messagebox as box

#initializing window variable
window = Tk()

#START is the window title now
window.title("START")

frame = Frame(window)

label = Label(frame, text = "Give me an Object")
entry = Entry(frame)

def dialog():
    box.showinfo('Open', 'Shit '+entry.get())

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
