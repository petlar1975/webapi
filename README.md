# Web API prototype project
This repository stores a REST API project. It is a small prototype that is similar to a real project, that will be relevant for the back-end position.

Below is a few tasks that we have prepared for you. We only expect you to spend around 3 hours on this – not days. The most important is for us to get insight into your understanding/thinking. We ask you to do the following:

1. Fork this repo to your own GitHub account and clone your fork to your machine. Run the application and get an overview over how it is working.
2. Review the code base and think about how it could be improved – especially the general structure and code patterns.
3. Choose to do some relevant changes, accompanied by inline comments explaining the change and why.
4. More overall thoughts/suggestions/ideas for the code or architecture should be added below in this README. This also gives you a chance to mention changes that you did not have time to do in the short timeframe.
5. Push and make a pull request to this repository with your changes.

----

#### Add general thoughts/suggestions/ideas here:
Number of projects should be reduced. I see 2 major responsebilities. Handling data and/or the restapi. And also a 3rd for shared resources like interfaces or models

1. Bookservice, responsible for rest-api and authentication. Implementation should be here. Controllers can access Repository directly
2. Data, responsible for posting and getting data from database. I would keep Repository as it is
3. Core, A project containing shared resources like interfaces and domainmodel. Model and interfaces goes here

##### DB setup
I noticed the connectionstring was pointing at a backup .mdf-file, but there wasnt one included in the masterbranch, so the only to get the project running was to start building an empty DB. By adding migrations, I added files to build a DB through EF code-first. Later migrations can handle changes in the datamodel. I also want the service to check if a DB is present and check if the newest migration is used.

In the datamodel I noticed that Book and ExtendedBook had duplicate properties, and could easily be merged into one object/model

##### localhost-startup
When launching project, a localhost was opened in my browser. As this is a service giving acces to a rest-api, this seems wrong. There shouldnt be any UI. Despite this, I saw routing was pointing at at default index view in the HOME-controller. A HOME-controller didnt exist, so I tried adding one, to see if it was giving me a new error, to help me get to the next step of running the BooksApp

##### Other thoughts
I saw the different components werent connected. I am missing a Program.cs file in the main project, to work out how the App is built and the different components are connected.

It also seemed that the project is broken in many places and on different levels. I decided to fix issues, where my strengths lies. Near the database and data-layer

