# CAR-RACING-GAME




https://user-images.githubusercontent.com/119212839/211185438-7520defb-b494-4a6e-ae8f-28db9e078f17.mp4


2D-CAR-RACING-GAME-IMPLEMENTING-THE-DEPENDENCY-INJECTION-ZENJECT
Zenject is a lightweight highly performant dependency injection framework built specifically to target Unity 3D (however it can be used outside of Unity as well). It can be used to turn your application into a collection of loosely coupled parts with highly segmented responsibilities I use zenject to call the script uiManager to the script carController. This is because the instance uiManager can be called many times. Zenject allows me to edit the frequently called class. Without having to make changes to the script that is calling it. Zenject is used in place of GetObject<>(); and FindObjectofType<>();, but in zenject you dont have to edit the code dependancies
