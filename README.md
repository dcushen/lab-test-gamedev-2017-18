# lab-test-gamedev-2017-18

lab test 2017-18: Friday 12th Jan 2017

1.
fork this repo, and then clone from your fork to the local machine

2.
Create some post-constructor unit tests

    - strength is 100
    - repairQuantity is 10
    - repairThreshold is 25 (below which strength shields cannot auto repair on each Tick())
    - IsRepairAble() method returns true

3.
Create some post-action unit tests

    - test that after 1 damage of 1, the IsRepairable method returns TRUE and the strength is 99
    - test that after 1 damage of 10, the IsRepairable method returns TRUE and the strength is 90
    - test that after 8 damage of 10, the IsRepairable method returns FALSE and the strength is 20
    - test that after 1 damage of 90, the IsRepairable method returns FALSE and the strength is 10
    - test that after 1 damage of 11 followed by 1 Tick, the strength is 99
    
4.
You have been given a Scene in the Unity project

    Add View-Controller-Manager scripts to allow the scene to change the model
    (i.e. when user clicks button Damage 1 or Damage 10, the Damage is applied,
    also if user click button Tick, if shield is not below threshold, then a repair is achieved
    and the status on screen updated to refect any changes to the model values)
    
    Note - the user sees the Strength and IsRepairable status as text, 
    also as a colour circule image - 

    Note - as long as you separate View from Model from Controller (so at least 3 scripts in your system),
    feel free to implement how you wish
    (i.e.  you don't have to follow the sample MVC-mediating controller achitecture

    BUT - you must NOT make any changes to the provided Model class ....

    HINTS for image of strength: 
    Use a UI RawImage, have a public array of Textures passed to the view (as well as reference to UI RawImage)
    if strength > 90 show image 100, else if > 80 show image 080 ... else if > 1 show 010, else show image 000
    the texture property of the RawImage is set to the appropriate image texture

4.
commit your changes to your repo
and make a pull request to my original repo