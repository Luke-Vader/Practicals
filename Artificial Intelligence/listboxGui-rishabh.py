from tkinter import*
import tkinter.messagebox as messagebox

window = Tk()
window.title('ListBox')

frame = Frame(window)
listbox = Listbox(frame)

listbox.insert(1, 'Avinash')
listbox.insert(2, 'Suraj')
listbox.insert(3, 'Janak')

def masted():
    try:
        messagebox.showinfo('Mast AADMI', 'Congratulations '+listbox.get(listbox.curselection())+' tu MAST hai')
    except:
        messagebox.showerror('Mast AADMI', 'You selected nobody you are Not mast')
#showerror, showwarning, askquestion, askokcancel, askyeno,askretrycancel are the several dialog boxes that
#can be used

button = Button(frame, text = "Mast", command = masted)

listbox.pack()
button.pack(pady = 10)
frame.pack(padx = 40, pady = 20)

window.mainloop()
