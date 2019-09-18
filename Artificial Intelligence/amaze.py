import nltk
import tkinter as tk

window = tk.Tk()
tk.Label(window, text="Sentence: ", width = 15).grid(column = 0)
userInput = tk.Entry(window, width = 45)
userInput.grid(row=0, column=1)

def dialog():
    
    sentence = userInput.get()
    print(sentence)
    token = nltk.word_tokenize(sentence)
    print(nltk.pos_tag(token))
    grammar = ('''
    Noun Phrase: {<DT>?<JJ>*<NN>} # Noun Phrase
    ''')
    chunkParser = nltk.RegexpParser(grammar)
    tagged = nltk.pos_tag(nltk.word_tokenize(sentence))
    tree = chunkParser.parse(tagged)
    for subtree in tree.subtrees():
        print(subtree)
    print(tree.draw())

btn = tk.Button(window,text="Submit",command=dialog)
btn.grid(row=1)
window.mainloop()