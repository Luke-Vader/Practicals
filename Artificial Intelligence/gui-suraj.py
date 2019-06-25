from tkinter import*
import tkinter.messagebox as box

window=Tk()
window.title('Listbox demo')

frame=Frame(window)

lbl = Label(window,text = "Choose your Leader")  

listbox=Listbox(frame)

listbox.insert(1,'Rishabh')
listbox.insert(2,'Janak')
listbox.insert(3,'Suraj')


def dialog():
    box.showinfo("Leader","Your Choice"+listbox.get(listbox.curselection()))

btn=Button(frame,text="Vote",command=dialog)
lbl.pack()
listbox.pack()
frame.pack(padx = 40, pady = 20)
btn.pack()
window.mainloop()