Description du Projet
Ce projet implémente diverses transformations géométriques sur un objet 3D (cube) dans un environnement Unity. Les transformations possibles sont :

Translation : Déplace le cube dans l’espace 3D selon les valeurs des axes X, Y et Z.

Mise à l'échelle (Scaling) : Modifie la taille du cube en appliquant un facteur de mise à l’échelle sur chaque dimension.

Rotation : Effectue une rotation du cube autour des axes X, Y ou Z.

Réflexion : Applique une réflexion du cube par rapport aux axes X, Y ou Z.

Projection : Projette le cube sur un plan spécifique, comme le plan XY (z = 0).

Fonctionnalités Implémentées
1. Translation
Permet de déplacer le cube dans l'espace 3D en fonction des valeurs saisies par l'utilisateur pour les axes X, Y et Z.

Le déplacement est appliqué de manière instantanée à l’objet, et l'utilisateur peut voir l'effet en temps réel.

2. Mise à l'échelle (Scaling)
Applique une mise à l’échelle sur les axes X, Y et Z.

L'utilisateur entre des valeurs pour chaque dimension (par exemple, 1.0 pour ne pas changer la taille, 2.0 pour doubler la taille, etc.).

3. Rotation
Permet à l'utilisateur de faire tourner le cube autour des axes X, Y et Z en saisissant les valeurs de rotation en degrés.

La rotation est effectuée en temps réel à chaque application de la transformation.

4. Réflexion
Applique une réflexion du cube autour de l'un des axes X, Y ou Z.

L'inversion est effectuée en inversant les coordonnées correspondantes du cube, en fonction de la valeur de l’axe (s’il est différent de zéro).

5. Projection
Projette le cube sur un plan, généralement sur le plan XY (c’est-à-dire en définissant la coordonnée Z à 0).

Cette transformation élimine la profondeur et place le cube sur un plan bidimensionnel.

Structures de Données et Algorithmes
Les transformations géométriques sont appliquées en utilisant les Vecteurs (Vector3) et les Matrices. Ces structures permettent d'effectuer des calculs mathématiques nécessaires aux transformations sur les objets 3D. Unity utilise des objets Vector3 pour représenter les positions, échelles, et rotations des objets en 3D.

Translation : Utilisation de Vector3 pour additionner ou soustraire des vecteurs de transformation.

Mise à l'échelle : Vector3 est utilisé pour multiplier les coordonnées du cube par un facteur de mise à l'échelle sur chaque dimension.

Rotation : La rotation est appliquée avec la méthode Rotate de Unity, qui utilise des angles de rotation en degrés pour modifier l’orientation du cube autour de l’axe spécifié.

Réflexion : Inversion des coordonnées d’un Vector3 (par exemple, inversion des valeurs X, Y ou Z) pour créer l'effet de réflexion.

Projection : Réduction de la coordonnée Z à zéro pour projeter l'objet dans un plan 2D.

Simulation et Interaction Utilisateur
L'utilisateur peut interagir avec le programme via une interface graphique (UI) constituée de boutons et de champs de texte pour saisir les valeurs des transformations. Voici comment l’utilisateur interagit avec chaque transformation :

Choisir la transformation : L’utilisateur choisit une transformation à appliquer en cliquant sur l’un des boutons de transformation (Translation, Scaling, Rotation, Reflection, Projection).

Entrer les valeurs : Une fois la transformation choisie, des champs de texte (InputFields) apparaissent, permettant à l'utilisateur de saisir les valeurs nécessaires (par exemple, les valeurs pour X, Y et Z).

Appliquer la transformation : Après avoir saisi les valeurs, l’utilisateur clique sur un bouton "Appliquer" pour appliquer la transformation au cube en temps réel.

Toutes les transformations sont visibles immédiatement après avoir appuyé sur le bouton d’application, permettant ainsi à l'utilisateur de voir l’effet des transformations sur le cube.

Structure du Code
Classes Principales
TransformationScript : La classe principale qui gère toutes les transformations appliquées au cube. Elle contient des méthodes pour chaque transformation géométrique et permet de gérer l'interface utilisateur.

Méthodes principales :

ApplyTranslation()

ApplyScaling()

ApplyRotation()

ApplyReflection()

ApplyProjection()

Logique : En fonction de la transformation sélectionnée, la méthode correspondante est appelée pour modifier les propriétés du cube (position, échelle, rotation).

Méthodes
SetTransformation(): Active le panneau de saisie correspondant à la transformation choisie.

ApplyTransformation(): Applique la transformation en utilisant les valeurs saisies dans les champs de texte.

ApplyTranslation(), ApplyScaling(), ApplyRotation(), ApplyReflection(), ApplyProjection(): Effectuent les transformations respectives sur le cube.

UI
Des boutons sont associés à chaque transformation, et les champs de texte apparaissent dynamiquement lorsque l'utilisateur sélectionne une transformation à appliquer.

L'utilisateur peut appliquer les transformations en temps réel et voir le cube se déplacer, changer de taille, de rotation, ou de forme.

