# AutonForklift

Github Repo for Autonomous Forklift Project

#### Getting the repository onto your local machine

1. Install Git on your local machine https://git-scm.com/downloads
2. Navigate to the directory that you want the project to be stored in via the command line
3. Clone the repository to your chose directory using the command "https://github.com/ThanhL/AutonForklift.git" 

#### Importing project in to Unity

Open directory of your git in Unity


#### Making Changes and commiting to the repository

To commit your changes to the repository follow these steps from the command line:

1. Navigate to the AutonForklift directory
2. Type in "git status" to view any added, removed or modified files.
3. Type "git add -A". 
4. Type "git commit -m "Commit message" where Commit message simply states the changes you made.
5. Type "git push origin master" to commit to to remote repository


#### Getting the changes others have made to your local repository

To pull the changes others have made to the repository follow these steps from the command line:

1. Navigate to the AutonForklift directory
2. Type "git pull origin master" to update your local repository

NOTE:
It occasionally occurs that when two people have modified the same file there will be a merge conflict if the same line/s have been 
modified by two or more people. To fix this when you make a pull request, if there is a merge conflict the conflicting files should
show you where the conflict is. You can find out more about merge conflicts at https://help.github.com/articles/resolving-a-merge-conflict-from-the-command-line/