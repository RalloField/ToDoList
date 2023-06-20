# To Do List in C#

## Start of the C#-journey

This simple app is the first project I finished after covering the basics of C#. It is made entirely in MS Visual Studio 2022. 

---

#### Introduction

This simple application is meant to let you track your daily tasks. It has basic CRUD functionality and are displayed in a table format.

#### Breaking down the code and functionality

- We start by defining our namespaces (`ToDoList`), and declare our `class ToDoList`. This is an extention from the `Form` class -> `System.Windows.Forms`.
- We declare a DataTable object inside the ToDoList class, here we will store the list items as rows and columns
- We set the `isEditing` boolean to false. This keeps track of wheter the user is editing a to-do item.
- When the form is loaded, it creates two columns, "Title" and "Description", in the `todoList` DataTable.
- The four buttons have their own unique functionalities:
  - New item
  - Save item
  - Edit item
  - Delete item

#### This is but the beginning of many C# projects
