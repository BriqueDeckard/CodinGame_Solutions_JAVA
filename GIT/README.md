# GIT:

Avant une PR, il faut recuperer la progression de DEV sur la branche locale FEATURE.

There are a few methodologies, and it depends on the branching strategy that you are using. On a project-by-project basis, I would pick one strategy and stick with it, but the one that works best depends on what you are looking for.

# Merge vs Rebase:

## Merge:
From the branch:
- git pull
- git merge origin/develop
- git push

This preserves history and is non destructive. It creates a single new commit on the branch representing the change(s) from develop being brought into the branch

--> commit final VS. commit final

## Rebase: 
From the branch:
- git pull --rebase
- git rebase origin/develop
- git push --force


This REWRITES history and is destructive. The original commits on the branch are discarded and recreated (they will look similar (same comment, file and authorship), but will have different commit-ids and commit-time. It makes history more 'linear'.

--> attention au git push --force. Il vaut mieux regler les conflits un par uns, commit par commit.