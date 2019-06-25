from tkinter import*
import tkinter.messagebox as box

window=Tk()
window.title('Listbox demo')

frame=Frame(window)

listbox=Listbox(frame)

listbox.insert(1,'Rishabh')
listbox.insert(2,'Janak')
listbox.insert(3,'Suraj')

def dialog():
    box.showinfo("Leader","Your Choice"+listbox.get(listbox.curselection()))

btn=Button(frame,text="Vote",command=dialog)
listbox.pack()
frame.pack()
btn.pack()
window.mainloop()