# GIT:

[Source](https://delicious-insights.com/fr/articles/bien-utiliser-git-merge-et-rebase/)

Avant une PR, il faut recuperer la progression de DEV sur la branche locale FEATURE.

There are a few methodologies, and it depends on the branching strategy that you are using. On a project-by-project basis, I would pick one strategy and stick with it, but the one that works best depends on what you are looking for.

# Pull
To pull all the repositories in a folder : 
```
find . -mindepth 1 -maxdepth 1 -type d -print -exec git -C {} pull \;
```

# Merge vs Rebase:

Un git merge ne devrait être utilisé que pour la récupération fonctionnelle, intégrale et finale d’une branche dans une autre, afin de préserver un graphe d’historique sémantiquement cohérent et utile, lequel représente une véritable valeur ajoutée.

Tous les autres cas de figure relèvent du rebase sous toutes ses formes : classique, tri-partite, interactif ou cherry picking.

## Merge:
From the branch:

- ```git pull```
- ```git merge local/develop```
- ```git push```

This preserves history and is non destructive. It creates a single new commit on the branch representing the change(s) from develop being brought into the branch

--> commit final VS. commit final

Comme son nom l’indique, merge réalise une fusion. On souhaite faire avancer la branche courante de sorte qu’elle incorpore le travail d’une autre branche.

- S’agit-il d’une branche locale temporaire, que j’avais juste faite par précaution, afin de conserver un master propre pendant ce temps-là ? Si c’est le cas, il est inutile, et même contre-productif, que cette branche reste visible dans l’historique, en formant un « aiguillage » identifiable.

  Si la branche récipiendaire (par exemple master) a avancé entre-temps et que la branche à fusionner n’en est donc plus un descendant direct, on la traitera comme une branche « ancienne » et on aura recours à **rebase** pour conserver un graphe linéaire. Mais si master n’a pas avancé entre-temps, je vais pouvoir faire un fast-forward, qui est un mode automatique de **git merge**.

- S’il s’agit d’une branche « connue », identifiée par l’équipe ou simplement par mon planning de travail, le raisonnement s’inverse. La branche peut par exemple représenter un sprint ou une story en méthodologie agile, ou encore un ticket d’incident (issue ou bug) précis, identifié dans notre gestion de tâches.

Il est alors préférable, voire impératif, que l’étendue de cette branche demeure visible dans le graphe de l’historique. Ce sera le cas si la branche récipiendaire (par exemple master) a avancé depuis que la branche à fusionner en a dérivé, mais si master est restée inactive, la branche à fusionner en est un descendant direct, et il faudra alors empêcher Git de recourir automatiquement à l’astuce du fast-forward. **Dans les deux cas de figure, on utilisera merge, jamais rebase.**

## Rebase: 

Comme son nom l’indique, rebase est là pour changer la « base » d’une branche, c’est-à-dire son point de départ. Elle rejoue une série de commits à partir d’un nouvelle base de travail.

Ce besoin survient principalement quand un travail local (une série de commits) est considéré comme partant d’une base obsolète. Cela peut arriver plusieurs fois par jour, quand on essaie d’envoyer au remote nos commits locaux, pour découvrir que notre version de la branche distante trackée (par exemple origin/master) date : depuis notre dernière synchro avec le remote, quelqu’un a déjà envoyé des évolutions de notre branche au serveur, du coup notre propre travail part d’une base plus ancienne, et l’envoyer tel quel au serveur reviendrait à écraser le travail récent des copains. C’est pourquoi push nous enverrait promener.

From the branch:
- git pull --rebase
- git rebase origin/develop
- git push --force


This REWRITES history and is destructive. The original commits on the branch are discarded and recreated (they will look similar (same comment, file and authorship), but will have different commit-ids and commit-time. It makes history more 'linear'.

--> attention au git push --force. Il vaut mieux regler les conflits un par uns, commit par commit.

## Reset:

Discarding all local commits on this branch
In order to discard all local commits on this branch, to make the local branch identical to the "upstream" of this branch, simply run ```git reset --hard @{u}```
