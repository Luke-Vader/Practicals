from tkinter import*
import tkinter.messagebox as messagebox

user_score = 0
machine_score = 0

window = Tk()
window.title('Rock Paper Scissors')
frame = Frame(window)
label = Label(window, text = "User: " + user_score)
label = Label(window, text = "Machine: " + machine _score)

frame.pack(padx = 200, pady = 100)

window.mainloop()