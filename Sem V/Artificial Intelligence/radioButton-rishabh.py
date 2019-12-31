from tkinter import*
import tkinter.messagebox as messagebox

window = Tk()
window.title('Subject Selector')
frame = Frame(window)

lang = StringVar()

html = Radiobutton(frame, text = "HTML", variable = lang, value = "It's not even a programming language")
python = Radiobutton(frame, text = "Python", variable = lang, value = "It's really boring")
java = Radiobutton(frame, text = "Java", variable = lang, value = "The Java people will be proud")
lang.set(None)
def decision():
    messagebox.showinfo("You are Done", lang.get())

button = Button(frame, text = "Khatam", command = decision)

html.pack(side = LEFT)
python.pack(side = LEFT)
java.pack(side = LEFT)
button.pack()
frame.pack(padx = 100)

window.mainloop()