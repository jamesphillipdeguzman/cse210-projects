# Version Control
#### 6/11/2024
#### Author: James Phillip De Guzman
#### Course: CSE210 - Programming with Classes
## Git and GitHub


    1) Explain the meaning of Version Control

Version Control is very important because it helps us keep track of where the project is at, so we can communicate the progress of a technical project (e.g., software application project in this case) to the stakeholders (meaning your boss and team mates).

    2) Highlight a benefit of Version Control

I really like the idea of Distributed Version Control System because it answers the following question in relation to software application project:

    a) Who created the source code?
    b) What changes were made to it?
    c) When were the changes made?
    d) Why was the code changed?

Creating remarks/documentation for effective team collaboration in a project is an important skill. This is where DVCS shines.

    3) Provide an application of Version Control

A popular version control software often used by about 90% of programmers is **Git**. Git is a software program that helps manage file versioning and stores them in a repository, a.k.a. a "repo". It is a **DVCS** or Distributed Version Control System. Git was originally used for the development of Linux kernel by Linus Torvalds.


**GitHub** is a central "repo" where a developer can collaborate with other team members to work on the same project. For example, if developer A has new code in his local repo, he can push his commits to GitHub so that the main repo in GitHub will have his source code copied. If developer B, wants to see what was committed in the main repo, all he needs to do is to make a pull request from the main branch, and then, GitHub would automatically sync those changes made by developer A to his own local repository.

    4) Show a command used in Version Control

To stage your file, use the command git add. We use this when we want to add a file to the staging area prior to committing/saving the file. (See detailed steps below).

    5) Thoroughly explain these concepts:


To add a file to the staging area, use **git add.**
```
     git add sandbox/Sandbox/program.cs

```

To unstage a file that was just added, use **git restore --staged.**
```
    git restore --staged sandbox/Sandbox/program.cs
```
To check the status of your actions, use **git status.**
```
    git status
```
To commit or save changes to your local repo, use **git commit.** Don't forget to add your own message. Therefore, use **git commit -m.**
```
    git commit -m "Changed text to Hello World".
```
To see changes that you've made in GitHub (or to your central repo that you are working on yourself/others), use **git push.**
```
    git push

```
If you've made changes to your file in GitHub, for example you've changed some text in your readme.md file, but at the same time, you've made changes to your sandbox/Sandbox/program.cs (i.e., your hello world C# program), you won't be able to "push" your changes just yet (because you would get an error in your command line), unless you "pull" first from the modified record in GitHub.

```
    git pull
```
```
    git push
```

