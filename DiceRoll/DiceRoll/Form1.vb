Imports System.IO

Public Class Form1

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '---------------Global Variables to hold random values of the dice--------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Dim rnd As New Random
    Dim x, y, z, i, j As Integer

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '---------------Global Boolean Variables of the dice to determine---------
    '---------------which dice to be shown on a roll--------------------------
    '-------------------------------------------------------------------------

    Dim diceKeep1 As New Boolean
    Dim diceKeep2 As New Boolean
    Dim diceKeep3 As New Boolean
    Dim diceKeep4 As New Boolean
    Dim diceKeep5 As New Boolean

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '---------------Global Variables to keep track of how many times----------
    '---------------Keep was clicked and the limit of turns-------------------
    '-------------------------------------------------------------------------

    Dim counter1, counter2, counter3, counter4, counter5 As Integer
    Dim turnCounter As Integer

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '---------------Global Variables to hold the values of the dice-----------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Dim a As Integer = 1
    Dim b As Integer = 2
    Dim c As Integer = 3
    Dim d As Integer = 4
    Dim e As Integer = 5
    Dim f As Integer = 6

    Dim ace1, ace2, ace3, ace4, ace5 As Integer
    Dim twos1, twos2, twos3, twos4, twos5 As Integer
    Dim threes1, threes2, threes3, threes4, threes5 As Integer
    Dim fours1, fours2, fours3, fours4, fours5 As Integer
    Dim fives1, fives2, fives3, fives4, fives5 As Integer
    Dim sixes1, sixes2, sixes3, sixes4, sixes5 As Integer

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '-----------Dice variables to roll and choose a dice randomly-------------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Private Sub Rolldice1(x)            'Method to roll the pics of the first dice
        If diceKeep1 = False Then           'If statement to run through the pics of the dice if the user chooses not to hold that dice pic

            Select Case x                   'Case statement to show the dice pic

                'Case 1 shows the pic of dice side 1
                Case 1          
                    Dice1_1.Visible = True
                    Dice2_1.Visible = False
                    Dice3_1.Visible = False
                    Dice4_1.Visible = False
                    Dice5_1.Visible = False
                    Dice6_1.Visible = False
                
                'Case 2 shows the pic of dice side 2 
                Case 2
                    Dice1_1.Visible = False
                    Dice2_1.Visible = True
                    Dice3_1.Visible = False
                    Dice4_1.Visible = False
                    Dice5_1.Visible = False
                    Dice6_1.Visible = False
                
                'Case 3 shows the pic of dice side 3
                Case 3
                    Dice1_1.Visible = False
                    Dice2_1.Visible = False
                    Dice3_1.Visible = True
                    Dice4_1.Visible = False
                    Dice5_1.Visible = False
                    Dice6_1.Visible = False
                
                'Case 4 shows the pic of dice side 4
                Case 4
                    Dice1_1.Visible = False
                    Dice2_1.Visible = False
                    Dice3_1.Visible = False
                    Dice4_1.Visible = True
                    Dice5_1.Visible = False
                    Dice6_1.Visible = False
                
                'Case 5 shows the pic of dice side 5
                Case 5
                    Dice1_1.Visible = False
                    Dice2_1.Visible = False
                    Dice3_1.Visible = False
                    Dice4_1.Visible = False
                    Dice5_1.Visible = True
                    Dice6_1.Visible = False
                
                'Case 6 shows the pic of dice side 6
                Case 6
                    Dice1_1.Visible = False
                    Dice2_1.Visible = False
                    Dice3_1.Visible = False
                    Dice4_1.Visible = False
                    Dice5_1.Visible = False
                    Dice6_1.Visible = True
            End Select
        End If

    End Sub

    Private Sub Rolldice2(y)            'Method to roll the pics of the second dice
        If diceKeep2 = False Then           'If statement to run through the pics of the dice if the user chooses not to hold that dice pic

            Select Case y                   'Case statement to show the dice pic

                'Case 1 shows the pic of dice side 1
                Case 1
                    Dice1_2.Visible = True
                    Dice2_2.Visible = False
                    Dice3_2.Visible = False
                    Dice4_2.Visible = False
                    Dice5_2.Visible = False
                    Dice6_2.Visible = False

                'Case 2 shows the pic of dice side 2 
                Case 2
                    Dice1_2.Visible = False
                    Dice2_2.Visible = True
                    Dice3_2.Visible = False
                    Dice4_2.Visible = False
                    Dice5_2.Visible = False
                    Dice6_2.Visible = False
                    
                'Case 3 shows the pic of dice side 3
                Case 3
                    Dice1_2.Visible = False
                    Dice2_2.Visible = False
                    Dice3_2.Visible = True
                    Dice4_2.Visible = False
                    Dice5_2.Visible = False
                    Dice6_2.Visible = False

                'Case 4 shows the pic of dice side 4
                Case 4
                    Dice1_2.Visible = False
                    Dice2_2.Visible = False
                    Dice3_2.Visible = False
                    Dice4_2.Visible = True
                    Dice5_2.Visible = False
                    Dice6_2.Visible = False

                'Case 5 shows the pic of dice side 5
                Case 5
                    Dice1_2.Visible = False
                    Dice2_2.Visible = False
                    Dice3_2.Visible = False
                    Dice4_2.Visible = False
                    Dice5_2.Visible = True
                    Dice6_2.Visible = False

                'Case 6 shows the pic of dice side 6
                Case 6
                    Dice1_2.Visible = False
                    Dice2_2.Visible = False
                    Dice3_2.Visible = False
                    Dice4_2.Visible = False
                    Dice5_2.Visible = False
                    Dice6_2.Visible = True
            End Select

        End If

    End Sub

    Private Sub Rolldice3(z)                'Method to roll the pics of the third dice
        If diceKeep3 = False Then               'If statement to run through the pics of the dice if the user chooses not to hold that dice pic

            Select Case z                   'Case statement to show the dice pic

                'Case 1 shows the pic of dice side 1
                Case 1
                    Dice1_3.Visible = True
                    Dice2_3.Visible = False
                    Dice3_3.Visible = False
                    Dice4_3.Visible = False
                    Dice5_3.Visible = False
                    Dice6_3.Visible = False

                'Case 2 shows the pic of dice side 2 
                Case 2
                    Dice1_3.Visible = False
                    Dice2_3.Visible = True
                    Dice3_3.Visible = False
                    Dice4_3.Visible = False
                    Dice5_3.Visible = False
                    Dice6_3.Visible = False

                'Case 3 shows the pic of dice side 3 
                Case 3
                    Dice1_3.Visible = False
                    Dice2_3.Visible = False
                    Dice3_3.Visible = True
                    Dice4_3.Visible = False
                    Dice5_3.Visible = False
                    Dice6_3.Visible = False
                
                'Case 4 shows the pic of dice side 4
                Case 4
                    Dice1_3.Visible = False
                    Dice2_3.Visible = False
                    Dice3_3.Visible = False
                    Dice4_3.Visible = True
                    Dice5_3.Visible = False
                    Dice6_3.Visible = False

                'Case 5 shows the pic of dice side 5
                Case 5
                    Dice1_3.Visible = False
                    Dice2_3.Visible = False
                    Dice3_3.Visible = False
                    Dice4_3.Visible = False
                    Dice5_3.Visible = True
                    Dice6_3.Visible = False

                'Case 6 shows the pic of dice side 6
                Case 6
                    Dice1_3.Visible = False
                    Dice2_3.Visible = False
                    Dice3_3.Visible = False
                    Dice4_3.Visible = False
                    Dice5_3.Visible = False
                    Dice6_3.Visible = True
            End Select
        End If
    End Sub

    Private Sub Rolldice4(i)                'Method to roll the pics of the fourth dice
        If diceKeep4 = False Then               'If statement to run through the pics of the dice if the user chooses not to hold that dice pic

            Select Case i                   'Case statement to show the dice pic

                'Case 1 shows the pic of dice side 1
                Case 1
                    Dice1_4.Visible = True
                    Dice2_4.Visible = False
                    Dice3_4.Visible = False
                    Dice4_4.Visible = False
                    Dice5_4.Visible = False
                    Dice6_4.Visible = False
                
                'Case 2 shows the pic of dice side 2 
                Case 2
                    Dice1_4.Visible = False
                    Dice2_4.Visible = True
                    Dice3_4.Visible = False
                    Dice4_4.Visible = False
                    Dice5_4.Visible = False
                    Dice6_4.Visible = False

                'Case 3 shows the pic of dice side 3 
                Case 3
                    Dice1_4.Visible = False
                    Dice2_4.Visible = False
                    Dice3_4.Visible = True
                    Dice4_4.Visible = False
                    Dice5_4.Visible = False
                    Dice6_4.Visible = False

                'Case 4 shows the pic of dice side 4
                Case 4
                    Dice1_4.Visible = False
                    Dice2_4.Visible = False
                    Dice3_4.Visible = False
                    Dice4_4.Visible = True
                    Dice5_4.Visible = False
                    Dice6_4.Visible = False

                'Case 5 shows the pic of dice side 5
                Case 5
                    Dice1_4.Visible = False
                    Dice2_4.Visible = False
                    Dice3_4.Visible = False
                    Dice4_4.Visible = False
                    Dice5_4.Visible = True
                    Dice6_4.Visible = False

                'Case 6 shows the pic of dice side 6
                Case 6
                    Dice1_4.Visible = False
                    Dice2_4.Visible = False
                    Dice3_4.Visible = False
                    Dice4_4.Visible = False
                    Dice5_4.Visible = False
                    Dice6_4.Visible = True
            End Select

        End If

    End Sub

    Private Sub Rolldice5(j)                'Method to roll the pics of the fifth dice
        If diceKeep5 = False Then               'If statement to run through the pics of the dice if the user chooses not to hold that dice pic

            Select Case j                   'Case statement to show the dice pic

                'Case 1 shows the pic of dice side 1
                Case 1
                    Dice1_5.Visible = True
                    Dice2_5.Visible = False
                    Dice3_5.Visible = False
                    Dice4_5.Visible = False
                    Dice5_5.Visible = False
                    Dice6_5.Visible = False

                'Case 2 shows the pic of dice side 2 
                Case 2
                    Dice1_5.Visible = False
                    Dice2_5.Visible = True
                    Dice3_5.Visible = False
                    Dice4_5.Visible = False
                    Dice5_5.Visible = False
                    Dice6_5.Visible = False

                'Case 3 shows the pic of dice side 3 
                Case 3
                    Dice1_5.Visible = False
                    Dice2_5.Visible = False
                    Dice3_5.Visible = True
                    Dice4_5.Visible = False
                    Dice5_5.Visible = False
                    Dice6_5.Visible = False
                    
                'Case 4 shows the pic of dice side 4
                Case 4
                    Dice1_5.Visible = False
                    Dice2_5.Visible = False
                    Dice3_5.Visible = False
                    Dice4_5.Visible = True
                    Dice5_5.Visible = False
                    Dice6_5.Visible = False

                'Case 5 shows the pic of dice side 5
                Case 5
                    Dice1_5.Visible = False
                    Dice2_5.Visible = False
                    Dice3_5.Visible = False
                    Dice4_5.Visible = False
                    Dice5_5.Visible = True
                    Dice6_5.Visible = False
                
                'Case 6 shows the pic of dice side 6
                Case 6
                    Dice1_5.Visible = False
                    Dice2_5.Visible = False
                    Dice3_5.Visible = False
                    Dice4_5.Visible = False
                    Dice5_5.Visible = False
                    Dice6_5.Visible = True
            End Select
        End If

    End Sub

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '------------------Holds the Dice Values for each Dice--------------------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Private Sub Keep1_Click(sender As Object, e As EventArgs) Handles Keep1.Click               'Method to hold the pic of the first dice

        If ((counter1 Mod 2) = 1) Then                  'If statement to show the button wasn't clicked
            diceKeep1 = False
            Keep1.BackColor = Color.GhostWhite          'Changes the background color to show the button was clicked
        End If

        If ((counter1 Mod 2) = 0) Then                  'If statement to show the button was clicked
            diceKeep1 = True
            Keep1.BackColor = Color.Aqua                'Changes the background color to show the button was clicked
        End If

        counter1 += 1                   'Keeps track of how many times the user click the button
    End Sub

    Private Sub Keep2_Click(sender As Object, e As EventArgs) Handles Keep2.Click               'Method to hold the pic of the second dice

        If ((counter2 Mod 2) = 1) Then                  'If statement to show the button wasn't clicked
            diceKeep2 = False
            Keep2.BackColor = Color.GhostWhite          'Changes the background color to show the button was clicked
        End If

        If ((counter2 Mod 2) = 0) Then                  'If statement to show the button was clicked
            diceKeep2 = True
            Keep2.BackColor = Color.Aqua                'Changes the background color to show the button was clicked
        End If
        counter2 += 1                   'Keeps track of how many times the user click the button

    End Sub

    Private Sub Keep3_Click(sender As Object, e As EventArgs) Handles Keep3.Click               'Method to hold the pic of the third dice

        If ((counter3 Mod 2) = 1) Then                  'If statement to show the button wasn't clicked
            diceKeep3 = False
            Keep3.BackColor = Color.GhostWhite          'Changes the background color to show the button was clicked
        End If

        If ((counter3 Mod 2) = 0) Then                  'If statement to show the button was clicked
            diceKeep3 = True
            Keep3.BackColor = Color.Aqua                'Changes the background color to show the button was clicked
        End If
        counter3 += 1                   'Keeps track of how many times the user click the button

    End Sub

    Private Sub Keep4_Click(sender As Object, e As EventArgs) Handles Keep4.Click               'Method to hold the pic of the forth dice

        If ((counter4 Mod 2) = 1) Then                  'If statement to show the button wasn't clicked
            diceKeep4 = False
            Keep4.BackColor = Color.GhostWhite          'Changes the background color to show the button was clicked
        End If

        If ((counter4 Mod 2) = 0) Then                  'If statement to show the button was clicked
            diceKeep4 = True
            Keep4.BackColor = Color.Aqua                'Changes the background color to show the button was clicked
        End If
        counter4 += 1                   'Keeps track of how many times the user click the button
    End Sub

    Private Sub Keep5_Click(sender As Object, e As EventArgs) Handles Keep5.Click               'Method to hold the pic of the fifth dice

        If ((counter5 Mod 2) = 1) Then                  'If statement to show the button wasn't clicked
            diceKeep5 = False
            Keep5.BackColor = Color.GhostWhite          'Changes the background color to show the button was clicked
        End If

        If ((counter5 Mod 2) = 0) Then                  'If statement to show the button was clicked
            diceKeep5 = True
            Keep5.BackColor = Color.Aqua                'Changes the background color to show the button was clicked
        End If
        counter5 += 1                   'Keeps track of how many times the user click the button

    End Sub

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '-------------Hold and keep the total for the Upper score board-----------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Private Sub totalOfAces_Click(sender As Object, e As EventArgs) Handles totalOfAces.Click               'Method to hold the total of 1's

        totalOfAces.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub totalOfTwos_Click(sender As Object, e As EventArgs) Handles totalOfTwos.Click               'Method to hold the total of 2's 

        totalOfTwos.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub totalOfThrees_Click(sender As Object, e As EventArgs) Handles totalOfThrees.Click               'Method to hold the total of 3's

        totalOfThrees.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub totalOfFours_Click(sender As Object, e As EventArgs) Handles totalOfFours.Click               'Method to hold the total of 4's

        totalOfFours.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub totalOfFives_Click(sender As Object, e As EventArgs) Handles totalOfFives.Click               'Method to hold the total of 5's

        totalOfFives.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub totalOfSixes_Click(sender As Object, e As EventArgs) Handles totalOfSixes.Click               'Method to hold the total of 6's

        totalOfSixes.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub totalsScore_BackColorChanged(sender As Object, e As EventArgs) Handles totalsScore.BackColorChanged               'Method to show the total of (1-6)
        If (totalsScore.BackColor = Color.Aqua) Then
            totalSumOfUpperScore += CInt(totalOfAces.Text) + CInt(totalOfTwos.Text) + CInt(totalOfThrees.Text) + CInt(totalOfFours.Text) + CInt(totalOfFives.Text) + CInt(totalOfSixes.Text)                'Hold the total value of 1-6
            totalsScore.Text = CInt(totalSumOfUpperScore)               'Convert and display the total of 1-6 
            totalsScore.Enabled = False                 'Make the label be false to not allow any changes
        End If
    End Sub

    Private Sub bonusScore_BackColorChanged(sender As Object, e As EventArgs) Handles bonusScore.BackColorChanged               'Method to show the bonus score
        If (bonusScore.BackColor = Color.Aqua) Then
            bonusScore.Text = CInt(bonusPoints)                     'Convert and display the bonus score
            bonusScore.Enabled = False                 'Make the label be false to not allow any changes
        End If
    End Sub

    Private Sub total1_BackColorChanged(sender As Object, e As EventArgs) Handles total1.BackColorChanged               'Method to hold the total of 2's
        If (total1.BackColor = Color.Aqua) Then
            finalSumOfUpper = bonusPoints + totalsScore.Text                    'Hold the total of the upper bracket (total of (1-6) + bonus score)
            total1.Text = CInt(finalSumOfUpper)                     'Convert and display the total sum
            total1.Enabled = False                 'Make the label be false to not allow any changes
        End If
    End Sub

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '-------------Hold and keep the total for the Lower score board-----------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Private Sub scoreOf3Kind_Click(sender As Object, e As EventArgs) Handles scoreOf3Kind.Click               'Method to hold the score of 3 of a kind

        scoreOf3Kind.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub scoreOf4Kind_Click(sender As Object, e As EventArgs) Handles scoreOf4Kind.Click               'Method to hold the score of 4 of a kind

        scoreOf4Kind.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub scoreOfFullHouse_Click(sender As Object, e As EventArgs) Handles scoreOfFullHouse.Click               'Method to hold the score of full house

        scoreOfFullHouse.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub scoreOfSmStraight_Click(sender As Object, e As EventArgs) Handles scoreOfSmStraight.Click               'Method to hold the score of small straight

        scoreOfSmStraight.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub scoreOfLgStraight_Click(sender As Object, e As EventArgs) Handles scoreOfLgStraight.Click               'Method to hold the score of large straight

        scoreOfLgStraight.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub scoreYahtzee_Click(sender As Object, e As EventArgs) Handles scoreYahtzee.Click               'Method to hold the score of yahtzee

        scoreYahtzee.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub scoreOfChance_Click(sender As Object, e As EventArgs) Handles scoreOfChance.Click               'Method to hold the score of chance               

        scoreOfChance.BackColor = Color.Aqua              'Changes the background color to Aqua

        RollDice.BackColor = Color.GhostWhite               'Reset the Roll Button background color to GhostWhite
        turnCounter = 0             'Reset the turn counter to 0

        Keep1.BackColor = Color.GhostWhite                  'Reset the first Keep Button background color to GhostWhite
        
        If (Keep1.BackColor = Color.GhostWhite) Then            
            counter1 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep1 = False               'Reset the first keep back to false to show the dice animation
        End If

        Keep2.BackColor = Color.GhostWhite                  'Reset the second Keep Button background color to GhostWhite

        If (Keep2.BackColor = Color.GhostWhite) Then
            counter2 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep2 = False               'Reset the second keep back to false to show the dice animation
        End If

        Keep3.BackColor = Color.GhostWhite                  'Reset the third Keep Button background color to GhostWhite

        If (Keep3.BackColor = Color.GhostWhite) Then
            counter3 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep3 = False               'Reset the third keep back to false to show the dice animation
        End If

        Keep4.BackColor = Color.GhostWhite                  'Reset the forth Keep Button background color to GhostWhite

        If (Keep4.BackColor = Color.GhostWhite) Then
            counter4 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep4 = False               'Reset the forth keep back to false to show the dice animation
        End If

        Keep5.BackColor = Color.GhostWhite                  'Reset the fifth Keep Button background color to GhostWhite

        If (Keep5.BackColor = Color.GhostWhite) Then
            counter5 = 0                    'Reset the amount of times the user click the button to 0
            diceKeep5 = False               'Reset the fifth keep back to false to show the dice animation
        End If

        RollAnimation.Start()               'Calls the roll animation method to roll a dice
    End Sub

    Private Sub total2_BackColorChanged(sender As Object, e As EventArgs) Handles total2.BackColorChanged               'Method to hold the total of the lower section
        If (total2.BackColor = Color.Aqua) Then
            totalSumOfLowerScore = CInt(scoreOf3Kind.Text) + CInt(scoreOf4Kind.Text) + CInt(scoreOfFullHouse.Text) + CInt(scoreOfSmStraight.Text) + CInt(scoreOfLgStraight.Text) + CInt(scoreYahtzee.Text) + CInt(scoreOfChance.Text)                'Hold the total value of the lower section
            total2.Text = CInt(totalSumOfLowerScore)                'Convert and display the total value of the lower section
            total2.Enabled = False                 'Make the label be false to not allow any changes
        End If
    End Sub

    Private Sub grandTotal_BackColorChanged(sender As Object, e As EventArgs) Handles grandTotal.BackColorChanged               'Method to hold the total of the upper and lower section
        If (grandTotal.BackColor = Color.Aqua) Then

            finalScore = totalSumOfLowerScore + finalSumOfUpper                'Hold the total value of the upper and lower section

            grandTotal.Text = CInt(finalScore)                'Convert and display the total value of the upper and lower section

            Score_Board()               'Calls the method of score_Board

            If (list < finalScore) Then                 'If statement to check if the last recorded high score is lower than the new score
                hsFile = File.CreateText("score.txt")                   'Create and overwrite a new text file to record the new high score
                hsFile.WriteLine(finalScore)                        'Write in the final score into the text file
                hsFile.Close()                      'Close the file
            End If

            'Forgot to change it could go back to change if this part of the code gets in the way
            'Looks better as the following colors Black back ground with white text
            okButton.BackColor = Color.Black                    'Changes the back ground of the OK Button to Black
            okButton.ForeColor = Color.White                    'Changes the text of the OK Button to White

            gameOver.Visible = True                         'Display the Game Over text
            okButton.Visible = True                         'Display the OK Button 

            gameOver.BringToFront()                 'Move the Game Over text to the front
            okButton.BringToFront()                 'Move the OK Button to the front

        End If
    End Sub

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '----------------------Determines the dice value--------------------------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Private Sub Dice1Value()            'Method to find the value of the first dice

        If (Dice1_1.Visible = True) Then                    'If pic of dice side 1
            ace1 = a                                'ace1 is assign the value of 1
            twos1 = 0                               'twos1 is assign the value of 0
            threes1 = 0                             'threes1 is assign the value of 0
            fours1 = 0                              'fours1 is assign the value of 0
            fives1 = 0                              'fives1 is assign the value of 0
            sixes1 = 0                              'sixes1 is assign the value of 0
        End If

        If (Dice2_1.Visible = True) Then                    'If pic of dice side 2
            ace1 = 0                                'ace1 is assign the value of 0
            twos1 = b                               'twos1 is assign the value of 2
            threes1 = 0                             'threes1 is assign the value of 0
            fours1 = 0                              'fours1 is assign the value of 0
            fives1 = 0                              'fives1 is assign the value of 0
            sixes1 = 0                              'sixes1 is assign the value of 0
        End If

        If (Dice3_1.Visible = True) Then                    'If pic of dice side 3
            ace1 = 0                                'ace1 is assign the value of 0
            twos1 = 0                               'twos1 is assign the value of 0
            threes1 = c                             'threes1 is assign the value of 0
            fours1 = 0                              'fours1 is assign the value of 0
            fives1 = 0                              'fives1 is assign the value of 5
            sixes1 = 0                              'sixes1 is assign the value of 0
        End If

        If (Dice4_1.Visible = True) Then                    'If pic of dice side 4
            ace1 = 0                                'ace1 is assign the value of 0
            twos1 = 0                               'twos1 is assign the value of 0
            threes1 = 0                             'threes1 is assign the value of 0
            fours1 = d                              'fours1 is assign the value of 4
            fives1 = 0                              'fives1 is assign the value of 0
            sixes1 = 0                              'sixes1 is assign the value of 0
        End If

        If (Dice5_1.Visible = True) Then                    'If pic of dice side 5
            ace1 = 0                                'ace1 is assign the value of 0
            twos1 = 0                               'twos1 is assign the value of 0
            threes1 = 0                             'threes1 is assign the value of 0
            fours1 = 0                              'fours1 is assign the value of 0
            fives1 = e                              'fives1 is assign the value of 5
            sixes1 = 0                              'sixes1 is assign the value of 0
        End If

        If (Dice6_1.Visible = True) Then                    'If pic of dice side 6
            ace1 = 0                                'ace1 is assign the value of 0
            twos1 = 0                               'twos1 is assign the value of 0
            threes1 = 0                             'threes1 is assign the value of 0
            fours1 = 0                              'fours1 is assign the value of 0
            fives1 = 0                              'fives1 is assign the value of 0
            sixes1 = f                              'sixes1 is assign the value of 6
        End If

    End Sub

    Private Sub Dice2Value()

        If (Dice1_2.Visible = True) Then                    'If pic of dice side 1
            ace2 = a                                'ace2 is assign the value of 1
            twos2 = 0                               'twos2 is assign the value of 0
            threes2 = 0                             'threes2 is assign the value of 0
            fours2 = 0                              'fours2 is assign the value of 0
            fives2 = 0                              'fives2 is assign the value of 0
            sixes2 = 0                              'sixes2 is assign the value of 0
        End If

        If (Dice2_2.Visible = True) Then                    'If pic of dice side 2
            ace2 = 0                                'ace2 is assign the value of 0
            twos2 = b                               'twos2 is assign the value of 2
            threes2 = 0                             'threes2 is assign the value of 0
            fours2 = 0                              'fours2 is assign the value of 0
            fives2 = 0                              'fives2 is assign the value of 0
            sixes2 = 0                              'sixes2 is assign the value of 0
        End If

        If (Dice3_2.Visible = True) Then                    'If pic of dice side 3
            ace2 = 0                                'ace2 is assign the value of 0
            twos2 = 0                               'twos2 is assign the value of 0
            threes2 = c                             'threes2 is assign the value of 3
            fours2 = 0                              'fours2 is assign the value of 0
            fives2 = 0                              'fives2 is assign the value of 0
            sixes2 = 0                              'sixes2 is assign the value of 0
        End If

        If (Dice4_2.Visible = True) Then                    'If pic of dice side 4
            ace2 = 0                                'ace2 is assign the value of 0
            twos2 = 0                               'twos2 is assign the value of 0
            threes2 = 0                             'threes2 is assign the value of 0
            fours2 = d                              'fours2 is assign the value of 4
            fives2 = 0                              'fives2 is assign the value of 0
            sixes2 = 0                              'sixes2 is assign the value of 0
        End If

        If (Dice5_2.Visible = True) Then                    'If pic of dice side 5
            ace2 = 0                                'ace2 is assign the value of 0
            twos2 = 0                               'twos2 is assign the value of 0
            threes2 = 0                             'threes2 is assign the value of 0
            fours2 = 0                              'fours2 is assign the value of 0
            fives2 = e                              'fives2 is assign the value of 5
            sixes2 = 0                              'sixes2 is assign the value of 0
        End If

        If (Dice6_2.Visible = True) Then                    'If pic of dice side 6
            ace2 = 0                                'ace2 is assign the value of 0
            twos2 = 0                               'twos2 is assign the value of 0
            threes2 = 0                             'threes2 is assign the value of 0
            fours2 = 0                              'fours2 is assign the value of 0
            fives2 = 0                              'fives2 is assign the value of 0
            sixes2 = f                              'sixes2 is assign the value of 6
        End If

    End Sub

    Private Sub Dice3Value()

        If (Dice1_3.Visible = True) Then                    'If pic of dice side 1
            ace3 = a                                'ace3 is assign the value of 1
            twos3 = 0                               'twos3 is assign the value of 0
            threes3 = 0                             'threes3 is assign the value of 0
            fours3 = 0                              'fours3 is assign the value of 0
            fives3 = 0                              'fives3 is assign the value of 0
            sixes3 = 0                              'sixes3 is assign the value of 0
        End If

        If (Dice2_3.Visible = True) Then                    'If pic of dice side 2
            ace3 = 0                                'ace3 is assign the value of 0
            twos3 = b                               'twos3 is assign the value of 2
            threes3 = 0                             'threes3 is assign the value of 0
            fours3 = 0                              'fours3 is assign the value of 0
            fives3 = 0                              'fives3 is assign the value of 0
            sixes3 = 0                              'sixes3 is assign the value of 0
        End If

        If (Dice3_3.Visible = True) Then                    'If pic of dice side 3
            ace3 = 0                                'ace3 is assign the value of 0
            twos3 = 0                               'twos3 is assign the value of 0
            threes3 = c                             'threes3 is assign the value of 3
            fours3 = 0                              'fours3 is assign the value of 0
            fives3 = 0                              'fives3 is assign the value of 0
            sixes3 = 0                              'sixes3 is assign the value of 0
        End If

        If (Dice4_3.Visible = True) Then                    'If pic of dice side 4
            ace3 = 0                                'ace3 is assign the value of 0
            twos3 = 0                               'twos3 is assign the value of 0
            threes3 = 0                             'threes3 is assign the value of 0
            fours3 = d                              'fours3 is assign the value of 4
            fives3 = 0                              'fives3 is assign the value of 0
            sixes3 = 0                              'sixes3 is assign the value of 0
        End If

        If (Dice5_3.Visible = True) Then                    'If pic of dice side 5
            ace3 = 0                                'ace3 is assign the value of 0
            twos3 = 0                               'twos3 is assign the value of 0
            threes3 = 0                             'threes3 is assign the value of 0
            fours3 = 0                              'fours3 is assign the value of 0
            fives3 = e                              'fives3 is assign the value of 5
            sixes3 = 0                              'sixes3 is assign the value of 0
        End If

        If (Dice6_3.Visible = True) Then                    'If pic of dice side 6
            ace3 = 0                                'ace3 is assign the value of 0
            twos3 = 0                               'twos3 is assign the value of 0
            threes3 = 0                             'threes3 is assign the value of 0
            fours3 = 0                              'fours3 is assign the value of 0
            fives3 = 0                              'fives3 is assign the value of 0
            sixes3 = f                              'sixes3 is assign the value of 6
        End If

    End Sub

    Private Sub Dice4Value()

        If (Dice1_4.Visible = True) Then                    'If pic of dice side 1
            ace4 = a                                'ace4 is assign the value of 1
            twos4 = 0                               'twos4 is assign the value of 0
            threes4 = 0                             'threes4 is assign the value of 0
            fours4 = 0                              'fours4 is assign the value of 0
            fives4 = 0                              'fives4 is assign the value of 0
            sixes4 = 0                              'sixes4 is assign the value of 0
        End If

        If (Dice2_4.Visible = True) Then                    'If pic of dice side 2
            ace4 = 0                                'ace4 is assign the value of 0
            twos4 = b                               'twos4 is assign the value of 2
            threes4 = 0                             'threes4 is assign the value of 0
            fours4 = 0                              'fours4 is assign the value of 0
            fives4 = 0                              'fives4 is assign the value of 0
            sixes4 = 0                              'sixes4 is assign the value of 0
        End If

        If (Dice3_4.Visible = True) Then                    'If pic of dice side 3
            ace4 = 0                                'ace4 is assign the value of 0
            twos4 = 0                               'twos4 is assign the value of 0
            threes4 = c                             'threes4 is assign the value of 3
            fours4 = 0                              'fours4 is assign the value of 0
            fives4 = 0                              'fives4 is assign the value of 0
            sixes4 = 0                              'sixes4 is assign the value of 0
        End If

        If (Dice4_4.Visible = True) Then                    'If pic of dice side 4
            ace4 = 0                                'ace4 is assign the value of 0
            twos4 = 0                               'twos4 is assign the value of 0
            threes4 = 0                             'threes4 is assign the value of 0
            fours4 = d                              'fours4 is assign the value of 4
            fives4 = 0                              'fives4 is assign the value of 0
            sixes4 = 0                              'sixes4 is assign the value of 0
        End If

        If (Dice5_4.Visible = True) Then                    'If pic of dice side 5
            ace4 = 0                                'ace4 is assign the value of 0
            twos4 = 0                               'twos4 is assign the value of 0
            threes4 = 0                             'threes4 is assign the value of 0
            fours4 = 0                              'fours4 is assign the value of 0
            fives4 = e                              'fives4 is assign the value of 5
            sixes4 = 0                              'sixes4 is assign the value of 0
        End If

        If (Dice6_4.Visible = True) Then                    'If pic of dice side 6
            ace4 = 0                                'ace4 is assign the value of 0
            twos4 = 0                               'twos4 is assign the value of 0
            threes4 = 0                             'threes4 is assign the value of 0
            fours4 = 0                              'fours4 is assign the value of 0
            fives4 = 0                              'fives4 is assign the value of 0
            sixes4 = f                              'sixes4 is assign the value of 6
        End If

    End Sub

    Private Sub Dice5Value()

        If (Dice1_5.Visible = True) Then                    'If pic of dice side 1
            ace5 = a                                'ace5 is assign the value of 1
            twos5 = 0                               'twos5 is assign the value of 0
            threes5 = 0                             'threes5 is assign the value of 0
            fours5 = 0                              'fours5 is assign the value of 0
            fives5 = 0                              'fives5 is assign the value of 0
            sixes5 = 0                              'sixes5 is assign the value of 0
        End If

        If (Dice2_5.Visible = True) Then                    'If pic of dice side 1
            ace5 = 0                                'ace5 is assign the value of 0
            twos5 = b                               'twos5 is assign the value of 2
            threes5 = 0                             'threes5 is assign the value of 0
            fours5 = 0                              'fours5 is assign the value of 0
            fives5 = 0                              'fives5 is assign the value of 0
            sixes5 = 0                              'sixes5 is assign the value of 0
        End If

        If (Dice3_5.Visible = True) Then                    'If pic of dice side 1
            ace5 = 0                                'ace5 is assign the value of 0
            twos5 = 0                               'twos5 is assign the value of 0
            threes5 = c                             'threes5 is assign the value of 3
            fours5 = 0                              'fours5 is assign the value of 0
            fives5 = 0                              'fives5 is assign the value of 0
            sixes5 = 0                              'sixes5 is assign the value of 0
        End If

        If (Dice4_5.Visible = True) Then                    'If pic of dice side 1
            ace5 = 0                                'ace5 is assign the value of 0
            twos5 = 0                               'twos5 is assign the value of 0
            threes5 = 0                             'threes5 is assign the value of 0
            fours5 = d                              'fours5 is assign the value of 4
            fives5 = 0                              'fives5 is assign the value of 0
            sixes5 = 0                              'sixes5 is assign the value of 0
        End If

        If (Dice5_5.Visible = True) Then                    'If pic of dice side 1
            ace5 = 0                                'ace5 is assign the value of 0
            twos5 = 0                               'twos5 is assign the value of 0
            threes5 = 0                             'threes5 is assign the value of 0
            fours5 = 0                              'fours5 is assign the value of 0
            fives5 = e                              'fives5 is assign the value of 5
            sixes5 = 0                              'sixes5 is assign the value of 0
        End If

        If (Dice6_5.Visible = True) Then                    'If pic of dice side 1
            ace5 = 0                                'ace5 is assign the value of 0
            twos5 = 0                               'twos5 is assign the value of 0
            threes5 = 0                             'threes5 is assign the value of 0
            fours5 = 0                              'fours5 is assign the value of 0
            fives5 = 0                              'fives5 is assign the value of 0
            sixes5 = f                              'sixes5 is assign the value of 6
        End If

    End Sub

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '---------Global Variables to hold the values for the score board---------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Dim sumOf1s As Integer
    Dim sumOf2s As Integer
    Dim sumOf3s As Integer
    Dim sumOf4S As Integer
    Dim sumOf5s As Integer
    Dim sumOf6s As Integer
    Dim totalSumOfUpperScore As Integer
    Dim bonusPoints As Integer
    Dim finalSumOfUpper As Integer
    Dim threeOfaKindScore As Integer
    Dim fourOfaKindScore As Integer
    Dim fullHouseScore As Integer
    Dim smallStraightScore As Integer
    Dim largeStraightScore As Integer
    Dim yahtzeeScore As Integer
    Dim chanceScore As Integer
    Dim totalSumOfLowerScore As Integer
    Dim finalScore As Integer

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '--------------Determines the total for the score board-------------------
    '--------------------------Upper Section----------------------------------
    '-------------------------------------------------------------------------

    Private Sub HowManyAces(ace1, ace2, ace3, ace4, ace5)               'Method to get the total of 1's

        sumOf1s = ace1 + ace2 + ace3 + ace4 + ace5                  'sumOf1s total of all 1's

        If (totalOfAces.BackColor = Color.Aqua) Then                    'If statement when back ground color is Aqua
            totalOfAces.Enabled = False
        Else
            totalOfAces.Text = CInt(sumOf1s)                        'Display the current total score of 1's
        End If

    End Sub

    Private Sub HowManyTwos(twos1, twos2, twos3, twos4, twos5)               'Method to get the total of 2's

        sumOf2s = twos1 + twos2 + twos3 + twos4 + twos5                  'sumOf2s total of all 2's

        If (totalOfTwos.BackColor = Color.Aqua) Then                    'If statement when back ground color is Aqua
            totalOfTwos.Enabled = False
        Else
            totalOfTwos.Text = CInt(sumOf2s)                        'Display the current total score of 2's
        End If

    End Sub

    Private Sub HowManyThrees(threes1, threes2, threes3, threes4, threes5)               'Method to get the total of 3's

        sumOf3s = threes1 + threes2 + threes3 + threes4 + threes5                  'sumOf3s total of all 3's

        If (totalOfThrees.BackColor = Color.Aqua) Then                    'If statement when back ground color is Aqua
            totalOfThrees.Enabled = False
        Else
            totalOfThrees.Text = CInt(sumOf3s)                        'Display the current total score of 3's
        End If

    End Sub

    Private Sub HowManyFours(fours1, fours2, fours3, fours4, fours5)               'Method to get the total of 4's

        sumOf4S = fours1 + fours2 + fours3 + fours4 + fours5                  'sumOf4s total of all 4's

        If (totalOfFours.BackColor = Color.Aqua) Then                    'If statement when back ground color is Aqua
            totalOfFours.Enabled = False
        Else
            totalOfFours.Text = CInt(sumOf4S)                        'Display the current total score of 4's
        End If

    End Sub

    Private Sub HowManyFives(fives1, fives2, fives3, fives4, fives5)               'Method to get the total of 5's

        sumOf5s = fives1 + fives2 + fives3 + fives4 + fives5                  'sumOf5s total of all 5's

        If (totalOfFives.BackColor = Color.Aqua) Then                    'If statement when back ground color is Aqua
            totalOfFives.Enabled = False
        Else
            totalOfFives.Text = CInt(sumOf5s)                        'Display the current total score of 5's
        End If

    End Sub

    Private Sub HowManySixes(sixes1, sixes2, sixes3, sixes4, sixes5)               'Method to get the total of 6's

        sumOf6s = sixes1 + sixes2 + sixes3 + sixes4 + sixes5                  'sumOf6s total of all 6's

        If (totalOfSixes.BackColor = Color.Aqua) Then                    'If statement when back ground color is Aqua
            totalOfSixes.Enabled = False
        Else
            totalOfSixes.Text = CInt(sumOf6s)                        'Display the current total score of 6's
        End If

    End Sub

    Private Sub totalSum1(sumOf1s, sumOf2s, sumOf3s, sumOf4S, sumOf5s, sumOf6s)               'Method to get the total of (1-6)

        If (totalOfAces.Enabled = False And                         'If statement if 1-6 labels are all disable as false
            totalOfTwos.Enabled = False And
            totalOfThrees.Enabled = False And
            totalOfFours.Enabled = False And
            totalOfFives.Enabled = False And
            totalOfSixes.Enabled = False) Then      
            totalsScore.BackColor = Color.Aqua                      'Changes the background color to Aqua                      
            totalSumOfUpperScore += CInt(totalOfAces.Text) + CInt(totalOfTwos.Text) + CInt(totalOfThrees.Text) + CInt(totalOfFours.Text) + CInt(totalOfFives.Text) + CInt(totalOfSixes.Text)                'Hold the total value of 1-6

        End If

    End Sub

    Private Sub bonus(totalSumOfUpperScore)               'Method to get the bonus score

        If (totalsScore.Enabled = False And totalsScore.Text >= 63) Then                    'If statement to determine bonus score if score greater than or equal to 63 
            bonusPoints = 35                                'Bonus is assign 35                        
            bonusScore.BackColor = Color.Aqua                      'Changes the background color to Aqua
        End If
        If (totalsScore.Enabled = False And totalsScore.Text < 63) Then                    'If statement to determine bonus score if score is less than 63
            bonusPoints = 0                                'Bonus is assign 0
            bonusScore.BackColor = Color.Aqua                      'Changes the background color to Aqua
        End If

    End Sub

    Private Sub totalSumOfUpper(bonusPoints, totalSumOfUpperScore)               'Method to hold the total of 2's
        If (bonusScore.Enabled = False And totalsScore.Enabled = False) Then                            'If statement if both bonus and totalscore is disable false
            total1.BackColor = Color.Aqua                      'Changes the background color to Aqua
        End If
    End Sub

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '--------------Determines the total for the score board-------------------
    '--------------------------Lower Section----------------------------------
    '-------------------------------------------------------------------------

    Private Sub sumOf3OfaKind()               'Method to hold the score of 3 of a kind

        If (scoreOf3Kind.BackColor = Color.Aqua) Then                   'If statement if back ground color is Aqua
            scoreOf3Kind.Enabled = False                                'then the label is disable to false
        Else                                                            'If it isn't disable the label will show the current score
            If (sumOf1s >= 3) Then
                threeOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 3 - 1's
            End If
            If (sumOf2s >= 6) Then
                threeOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 3 - 2's
            End If
            If (sumOf3s >= 9) Then
                threeOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 3 - 3's
            End If
            If (sumOf4S >= 12) Then
                threeOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 3 - 4's
            End If
            If (sumOf5s >= 15) Then
                threeOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 3 - 5's
            End If
            If (sumOf6s >= 18) Then
                threeOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 3 - 6's
            End If

            scoreOf3Kind.Text = CInt(threeOfaKindScore)                     'Display the current score
            threeOfaKindScore = 0                           'Reset the score
        End If

    End Sub

    Private Sub sumOf4OfAKind()               'Method to hold the score of 4 of a kind

        If (scoreOf4Kind.BackColor = Color.Aqua) Then                   'If statement if back ground color is Aqua
            scoreOf4Kind.Enabled = False                                'then the label is disable to false
        Else                                                            'If it isn't disable the label will show the current score

            If (sumOf1s >= 4) Then
                fourOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 4 - 1's
            End If
            If (sumOf2s >= 8) Then
                fourOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 4 - 2's
            End If
            If (sumOf3s >= 12) Then
                fourOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 4 - 3's
            End If
            If (sumOf4S >= 16) Then
                fourOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 4 - 4's
            End If
            If (sumOf5s >= 20) Then
                fourOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 4 - 5's
            End If
            If (sumOf6s >= 24) Then
                fourOfaKindScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                       'Value score if there are 4 - 6's
            End If

            scoreOf4Kind.Text = CInt(fourOfaKindScore)                     'Display the current score
            fourOfaKindScore = 0                           'Reset the score
        End If

    End Sub

    Private Sub sumOfFullHouse()               'Method to hold the score of 3 of a kind

        If (scoreOfFullHouse.BackColor = Color.Aqua) Then                   'If statement if back ground color is Aqua
            scoreOfFullHouse.Enabled = False                                'then the label is disable to false
        Else                                                                'If it isn't disable the label will show the current score

            'Determines if it is a full house if there are 3 - 1's
            If (sumOf1s = 3) Then                   
                If (sumOf2s = 4) Then                           
                    fullHouseScore = 25                         'Value score if there are 2 - 2's
                End If
                If (sumOf3s = 6) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 3's
                End If
                If (sumOf4S = 8) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 4's 
                End If
                If (sumOf5s = 10) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 5's 
                End If
                If (sumOf6s = 12) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 6's 
                End If
            End If

            'Determines if it is a full house if there are 3 - 2's
            If (sumOf2s = 6) Then
                If (sumOf1s = 2) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 1's 
                End If
                If (sumOf3s = 6) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 3's 
                End If
                If (sumOf4S = 8) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 4's 
                End If
                If (sumOf5s = 10) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 5's 
                End If
                If (sumOf6s = 12) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 6's 
                End If
            End If

            'Determines if it is a full house if there are 3 - 3's
            If (sumOf3s = 9) Then
                If (sumOf1s = 2) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 1's 
                End If
                If (sumOf2s = 4) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 2's 
                End If
                If (sumOf4S = 8) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 4's 
                End If
                If (sumOf5s = 10) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 5's 
                End If
                If (sumOf6s = 12) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 6's 
                End If
            End If

            'Determines if it is a full house if there are 3 - 4's
            If (sumOf4S = 12) Then
                If (sumOf1s = 2) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 1's 
                End If
                If (sumOf2s = 4) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 2's 
                End If
                If (sumOf3s = 6) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 3's 
                End If
                If (sumOf5s = 10) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 5's 
                End If
                If (sumOf6s = 12) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 6's 
                End If
            End If

            'Determines if it is a full house if there are 3 - 5's
            If (sumOf5s = 15) Then
                If (sumOf1s = 2) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 1's 
                End If
                If (sumOf2s = 4) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 2's 
                End If
                If (sumOf3s = 6) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 3's 
                End If
                If (sumOf4S = 8) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 4's 
                End If
                If (sumOf6s = 12) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 6's 
                End If
            End If

            'Determines if it is a full house if there are 3 - 6's
            If (sumOf6s = 18) Then
                If (sumOf1s = 2) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 1's 
                End If
                If (sumOf2s = 4) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 2's 
                End If
                If (sumOf3s = 6) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 3's 
                End If
                If (sumOf4S = 8) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 4's 
                End If
                If (sumOf5s = 10) Then
                    fullHouseScore = 25                         'Value score if there are 2 - 5's 
                End If
            End If

            scoreOfFullHouse.Text = CInt(fullHouseScore)                     'Display the current score
            fullHouseScore = 0                           'Reset the score
        End If

    End Sub

    Private Sub sumOfSmallStraight()               'Method to hold the score of 3 of a kind

        If (scoreOfSmStraight.BackColor = Color.Aqua) Then                   'If statement if back ground color is Aqua
            scoreOfSmStraight.Enabled = False                                'then the label is disable to false
        Else                                                                 'If it isn't disable the label will show the current score

            If (sumOf1s = 1) Then
                If (sumOf2s >= 2 And sumOf3s >= 3 And sumOf4S >= 4) Then
                    smallStraightScore = 30                                 'Value score if there are 1-4
                End If
            End If

            If (sumOf2s = 2) Then
                If (sumOf3s >= 3 And sumOf4S >= 4 And sumOf5s >= 5) Then
                    smallStraightScore = 30                                 'Value score if there are 2-5
                End If
            End If

            If (sumOf3s = 3) Then
                If (sumOf4S >= 4 And sumOf5s >= 5 And sumOf6s >= 6) Then
                    smallStraightScore = 30                                 'Value score if there are 3-6
                End If
            End If

            scoreOfSmStraight.Text = CInt(smallStraightScore)                     'Display the current score
            smallStraightScore = 0                           'Reset the score
        End If

    End Sub

    Private Sub sumOfLargeStraight()               'Method to hold the score of 3 of a kind

        If (scoreOfLgStraight.BackColor = Color.Aqua) Then                   'If statement if back ground color is Aqua
            scoreOfLgStraight.Enabled = False                                'then the label is disable to false
        Else                                                                 'If it isn't disable the label will show the current score  

            If (sumOf1s = 1) Then
                If (sumOf2s = 2 And sumOf3s = 3 And sumOf4S = 4 And sumOf5s = 5) Then
                    largeStraightScore = 40                                 'Value score if there are 1-5
                End If
            End If

            If (sumOf2s = 2) Then
                If (sumOf3s = 3 And sumOf4S = 4 And sumOf5s = 5 And sumOf6s = 6) Then
                    largeStraightScore = 40                                 'Value score if there are 2-6
                End If
            End If

            scoreOfLgStraight.Text = CInt(largeStraightScore)                     'Display the current score
            largeStraightScore = 0                           'Reset the score
        End If

    End Sub

    Private Sub sumOfYahtzee()               'Method to hold the score of 3 of a kind

        If (scoreYahtzee.BackColor = Color.Aqua) Then                   'If statement if back ground color is Aqua
            scoreYahtzee.Enabled = False                                'then the label is disable to false
        Else                                                            'If it isn't disable the label will show the current score

            If (sumOf1s = 5) Then
                yahtzeeScore = 50                                 'Value score if there are 5 - 1's
            End If
            If (sumOf2s = 10) Then
                yahtzeeScore = 50                                 'Value score if there are 5 - 2's
            End If
            If (sumOf3s = 15) Then
                yahtzeeScore = 50                                 'Value score if there are 5 - 3's
            End If
            If (sumOf4S = 20) Then
                yahtzeeScore = 50                                 'Value score if there are 5 - 4's
            End If
            If (sumOf5s = 25) Then
                yahtzeeScore = 50                                 'Value score if there are 5 - 5's
            End If
            If (sumOf6s = 30) Then
                yahtzeeScore = 50                                 'Value score if there are 5 - 6's
            End If

            scoreYahtzee.Text = CInt(yahtzeeScore)                     'Display the current score
            yahtzeeScore = 0                           'Reset the score
        End If

    End Sub

    Private Sub sumOfChance()               'Method to hold the score of 3 of a kind

        If (scoreOfChance.BackColor = Color.Aqua) Then                   'If statement if back ground color is Aqua
            scoreOfChance.Enabled = False                                'then the label is disable to false
        Else                                                             'If it isn't disable the label will show the current score
            chanceScore = sumOf1s + sumOf2s + sumOf3s + sumOf4S + sumOf5s + sumOf6s                                 'Value score of all dice

            scoreOfChance.Text = CInt(chanceScore)                     'Display the current score
        End If

    End Sub

    Private Sub totalSum2()               'Method to hold the score of 3 of a kind

        If (scoreOf3Kind.Enabled = False And                            'If statement if the lower section labels are disabled as false
            scoreOf4Kind.Enabled = False And
            scoreOfFullHouse.Enabled = False And
            scoreOfSmStraight.Enabled = False And
            scoreOfLgStraight.Enabled = False And
            scoreYahtzee.Enabled = False And
            scoreOfChance.Enabled = False ) Then
            total2.BackColor = Color.Aqua                               'Changes the background color to Aqua 
            totalSumOfLowerScore = CInt(scoreOf3Kind.Text) + CInt(scoreOf4Kind.Text) + CInt(scoreOfFullHouse.Text) + CInt(scoreOfSmStraight.Text) + CInt(scoreOfLgStraight.Text) + CInt(scoreYahtzee.Text) + CInt(scoreOfChance.Text)
        End If
    End Sub

    Private Sub sumOfFinalScore()               'Method to hold the score of 3 of a kind
        If (total1.Enabled = False And total2.Enabled = False) Then                     'If statement if the upper and lower section total are disabled as false
            grandTotal.BackColor = Color.Aqua                               'Changes the background color to Aqua
        End If
    End Sub

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '--------------Determines the length of the Dice Animation----------------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Private Sub RollTime_Tick(sender As Object, e As EventArgs) Handles RollTime.Tick                     'Method to roll through the dice pics within a certain time

        RollAnimation.Stop()                        'Stop the animation of the dice roll

        If (RollAnimation.Enabled = False) Then                         'If the roll animation is disabled as false
            Dice1Value()                    'Calls the dice 1 method
            Dice2Value()                    'Calls the dice 2 method
            Dice3Value()                    'Calls the dice 3 method
            Dice4Value()                    'Calls the dice 4 method
            Dice5Value()                    'Calls the dice 5 method
        End If

        HowManyAces(ace1, ace2, ace3, ace4, ace5)                    'Calls the how many aces method
        HowManyTwos(twos1, twos2, twos3, twos4, twos5)                    'Calls the how many twos method
        HowManyThrees(threes1, threes2, threes3, threes4, threes5)                    'Calls the how many threes method
        HowManyFours(fours1, fours2, fours3, fours4, fours5)                    'Calls the how many fours method
        HowManyFives(fives1, fives2, fives3, fives4, fives5)                    'Calls the how many fives method
        HowManySixes(sixes1, sixes2, sixes3, sixes4, sixes5)                    'Calls the how many sixes method
        totalSum1(sumOf1s, sumOf2s, sumOf3s, sumOf4S, sumOf5s, sumOf6s)                    'Calls the total sum 1 method

        If (totalSumOfUpperScore >= 63) Then
            bonus(totalSumOfUpperScore)                    'Calls the bonus method
        End If

        totalSumOfUpper(bonusPoints, totalSumOfUpperScore)                    'Calls the total sum of upper method

        sumOf3OfaKind()                    'Calls the sum of 3 of a kind method
        sumOf4OfAKind()                    'Calls the sum of 4 of a kind method
        sumOfFullHouse()                    'Calls the sum of full house method
        sumOfSmallStraight()                    'Calls the sum of small straight method
        sumOfLargeStraight()                    'Calls the sum of large straight method
        sumOfYahtzee()                    'Calls the sum of Yahtzee method
        sumOfChance()                    'Calls the sum of chance method
        totalSum2()                    'Calls the sum of total sum 2 method
        sumOfFinalScore()                    'Calls the sum of final score method

    End Sub

    Private Sub RollAnimation_Tick(sender As Object, e As EventArgs) Handles RollAnimation.Tick                     'Method to roll through the dice pics within a certain time
        x = rnd.Next(1, 7)                      'Randomly gives a value 1-6 to x 
        y = rnd.Next(1, 7)                      'Randomly gives a value 1-6 to y
        z = rnd.Next(1, 7)                      'Randomly gives a value 1-6 to z
        i = rnd.Next(1, 7)                      'Randomly gives a value 1-6 to i
        j = rnd.Next(1, 7)                      'Randomly gives a value 1-6 to j

        Rolldice1(x)                      'Calls the Roll dice 1 method
        Rolldice2(y)                      'Calls the Roll dice 2 method
        Rolldice3(z)                      'Calls the Roll dice 3 method
        Rolldice4(i)                      'Calls the Roll dice 4 method
        Rolldice5(j)                      'Calls the Roll dice 5 method
    End Sub

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '-------------------------Dice Roll Animation-----------------------------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Private Sub RollDice_BackColorChanged(sender As Object, e As EventArgs) Handles RollDice.BackColorChanged               'Method to show when the user can't use the roll button anymore

        If (RollDice.BackColor = Color.Aqua) Then                           'If the background color is Aqua 
            RollDice.Enabled = False                                        'Roll dice is disable as False                                        
        End If

        If (RollDice.BackColor = Color.GhostWhite) Then                     'If the background color is Ghost White
            RollDice.Enabled = True                                         'Roll dice is enabled as True
            turnCounter = 0                                                 'Reset the turn counter to 0
        End If

    End Sub

    Private Sub RollDice_Click(sender As Object, e As EventArgs) Handles RollDice.Click               'Method to roll the dice

        If (turnCounter < 2) Then                               'If the turn counter is less then 2
            RollAnimation.Start()                               'Call the roll animation method
            turnCounter += 1                                    'Turn Counter adds 1
        End If

        If (turnCounter = 2) Then                               'If the turn counter is 2
            RollDice.BackColor = Color.Aqua                     'Change the back ground color Aqua
        End If

    End Sub

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '---------------------------Play the Game---------------------------------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Private Sub Play_Button_Click(sender As Object, e As EventArgs) Handles Play_Button.Click                           'Method to play the game

        resetValues()                                   'Calls the reset values method
        RollAnimation.Start()                           'Calls the roll animation to start

        GameMenuPic.SendToBack()                        'Move the main game picture to the back

        'Set these labels and buttons to false to keep it from showing up and keeping it clean for it to run good
        
        GameTitle.Visible = False
        Play_Button.Visible = False
        Scoreboard.Visible = False
        highScore.Visible = False
        score.Visible = False
        backButton.Visible = False
        exitButton.Visible = False
        gameOver.Visible = False
        okButton.Visible = False

        'Set these labels and buttons to true to keep it clean and runnable to play the game  

        lblUpperSection.Visible = True
        lblHowToScore.Visible = True
        lblGame1.Visible = True
        lblAces.Visible = True
        lblAddOnlyAces.Visible = True
        totalOfAces.Visible = True
        lblTwos.Visible = True
        lblAddOnlyTwos.Visible = True
        totalOfTwos.Visible = True
        lblThrees.Visible = True
        lblAddOnlyThrees.Visible = True
        totalOfThrees.Visible = True
        lblFours.Visible = True
        lblAddOnlyFours.Visible = True
        totalOfFours.Visible = True
        lblFives.Visible = True
        lblAddOnlyFives.Visible = True
        totalOfFives.Visible = True
        lblSixes.Visible = True
        lblAddOnlySixes.Visible = True
        totalOfSixes.Visible = True
        lblTotalScore.Visible = True
        Arrow1.Visible = True
        totalsScore.Visible = True
        lblBonus.Visible = True
        lblScore35.Visible = True
        bonusScore.Visible = True
        lblTotal1.Visible = True
        Arrow2.Visible = True
        total1.Visible = True
        lblLowerSection.Visible = True
        lbl3OfAKind.Visible = True
        lblAddTotalOnAllDice1.Visible = True
        scoreOf3Kind.Visible = True
        lbl4OfAKind.Visible = True
        lblAddTotalOnAllDice2.Visible = True
        scoreOf4Kind.Visible = True
        lblFullHouse.Visible = True
        lblScore25.Visible = True
        scoreOfFullHouse.Visible = True
        lblSmStraight.Visible = True
        lblScore30.Visible = True
        scoreOfSmStraight.Visible = True
        lblLgStraight.Visible = True
        lblScore40.Visible = True
        scoreOfLgStraight.Visible = True
        lblYahtzee.Visible = True
        lblScore50.Visible = True
        scoreYahtzee.Visible = True
        lblChance.Visible = True
        lblScoreTotalOfAll5Dice.Visible = True
        scoreOfChance.Visible = True
        lblTotal2.Visible = True
        Arrow3.Visible = True
        total2.Visible = True
        lblGrandTotal.Visible = True
        Arrow4.Visible = True
        grandTotal.Visible = True
        RollDice.Visible = True
        Keep1.Visible = True
        Keep2.Visible = True
        Keep3.Visible = True
        Keep4.Visible = True
        Keep5.Visible = True

    End Sub

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '---------------------------Score Board-----------------------------------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Dim hsFile As StreamWriter
    Dim sFile As StreamReader
    Dim list As New Integer

    Private Sub Score_Board()                           'Method to open and read the high score text file

        sFile = File.OpenText("score.txt")                      'Open the text file

        list = sFile.ReadLine()                         'List is reads and is assign the value from the text file
        sFile.Close()                                   'Close the file

        score.text = CInt(list)                         'Display the high score

    End Sub

    Private Sub Scoreboard_Click(sender As Object, e As EventArgs) Handles Scoreboard.Click                         'Method to display the high score

        GameMenuPic.SendToBack()                        'Move the main game picture to the back
        Score_Board()                                   'Calls the score board method

        'Set these labels and buttons to false to keep it from showing up and keeping it clean for it to run good

        GameTitle.Visible = False
        Play_Button.Visible = False
        Scoreboard.Visible = False
        lblUpperSection.Visible = False
        lblHowToScore.Visible = False
        lblGame1.Visible = False
        lblAces.Visible = False
        lblAddOnlyAces.Visible = False
        totalOfAces.Visible = False
        lblTwos.Visible = False
        lblAddOnlyTwos.Visible = False
        totalOfTwos.Visible = False
        lblThrees.Visible = False
        lblAddOnlyThrees.Visible = False
        totalOfThrees.Visible = False
        lblFours.Visible = False
        lblAddOnlyFours.Visible = False
        totalOfFours.Visible = False
        lblFives.Visible = False
        lblAddOnlyFives.Visible = False
        totalOfFives.Visible = False
        lblSixes.Visible = False
        lblAddOnlySixes.Visible = False
        totalOfSixes.Visible = False
        lblTotalScore.Visible = False
        Arrow1.Visible = False
        totalsScore.Visible = False
        lblBonus.Visible = False
        lblScore35.Visible = False
        bonusScore.Visible = False
        lblTotal1.Visible = False
        Arrow2.Visible = False
        total1.Visible = False
        lblLowerSection.Visible = False
        lbl3OfAKind.Visible = False
        lblAddTotalOnAllDice1.Visible = False
        scoreOf3Kind.Visible = False
        lbl4OfAKind.Visible = False
        lblAddTotalOnAllDice2.Visible = False
        scoreOf4Kind.Visible = False
        lblFullHouse.Visible = False
        lblScore25.Visible = False
        scoreOfFullHouse.Visible = False
        lblSmStraight.Visible = False
        lblScore30.Visible = False
        scoreOfSmStraight.Visible = False
        lblLgStraight.Visible = False
        lblScore40.Visible = False
        scoreOfLgStraight.Visible = False
        lblYahtzee.Visible = False
        lblScore50.Visible = False
        scoreYahtzee.Visible = False
        lblChance.Visible = False
        lblScoreTotalOfAll5Dice.Visible = False
        scoreOfChance.Visible = False
        lblTotal2.Visible = False
        Arrow3.Visible = False
        total2.Visible = False
        lblGrandTotal.Visible = False
        Arrow4.Visible = False
        grandTotal.Visible = False
        RollDice.Visible = False        
        exitButton.Visible = False
        gameOver.Visible = False
        okButton.Visible = False        
        Keep1.Visible = False
        Keep2.Visible = False
        Keep3.Visible = False
        Keep4.Visible = False
        Keep5.Visible = False
        Dice1_1.Visible = False
        Dice2_1.Visible = False
        Dice3_1.Visible = False
        Dice4_1.Visible = False
        Dice5_1.Visible = False
        Dice6_1.Visible = False
        Dice1_2.Visible = False
        Dice2_2.Visible = False
        Dice3_2.Visible = False
        Dice4_2.Visible = False
        Dice5_2.Visible = False
        Dice6_2.Visible = False
        Dice1_3.Visible = False
        Dice2_3.Visible = False
        Dice3_3.Visible = False
        Dice4_3.Visible = False
        Dice5_3.Visible = False
        Dice6_3.Visible = False
        Dice1_4.Visible = False
        Dice2_4.Visible = False
        Dice3_4.Visible = False
        Dice4_4.Visible = False
        Dice5_4.Visible = False
        Dice6_4.Visible = False
        Dice1_5.Visible = False
        Dice2_5.Visible = False
        Dice3_5.Visible = False
        Dice4_5.Visible = False
        Dice5_5.Visible = False
        Dice6_5.Visible = False

        'Set these labels and buttons to true to keep it clean and runnable to play the game  

        backButton.Visible = True
        score.Visible = True
        highScore.Visible = True

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click                         'Method to go back to the main menu

        'Set these labels and buttons to true to keep it clean and runnable to play the game 

        GameTitle.Visible = True
        Play_Button.Visible = True
        Scoreboard.Visible = True
        exitButton.Visible = True

        'Set these labels and buttons to false to keep it from showing up and keeping it clean for it to run good

        highScore.Visible = False
        score.Visible = False
        backButton.Visible = False

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click                             'Method to exit the application
        Me.Close()                      'Close the application
    End Sub

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click                             'Method to go back to the main menu after the game ends

        GameMenuPic.SendToBack()                       'Move the main game picture to the back

        'Set these labels and buttons to true to keep it clean and runnable to play the game 
        GameTitle.Visible = True
        Play_Button.Visible = True
        Scoreboard.Visible = True
        exitButton.Visible = True

        'Set these labels and buttons to false to keep it from showing up and keeping it clean for it to run good
        lblUpperSection.Visible = False
        lblHowToScore.Visible = False
        lblGame1.Visible = False
        lblAces.Visible = False
        lblAddOnlyAces.Visible = False
        totalOfAces.Visible = False
        lblTwos.Visible = False
        lblAddOnlyTwos.Visible = False
        totalOfTwos.Visible = False
        lblThrees.Visible = False
        lblAddOnlyThrees.Visible = False
        totalOfThrees.Visible = False
        lblFours.Visible = False
        lblAddOnlyFours.Visible = False
        totalOfFours.Visible = False
        lblFives.Visible = False
        lblAddOnlyFives.Visible = False
        totalOfFives.Visible = False
        lblSixes.Visible = False
        lblAddOnlySixes.Visible = False
        totalOfSixes.Visible = False
        lblTotalScore.Visible = False
        Arrow1.Visible = False
        totalsScore.Visible = False
        lblBonus.Visible = False
        lblScore35.Visible = False
        bonusScore.Visible = False
        lblTotal1.Visible = False
        Arrow2.Visible = False
        total1.Visible = False
        lblLowerSection.Visible = False
        lbl3OfAKind.Visible = False
        lblAddTotalOnAllDice1.Visible = False
        scoreOf3Kind.Visible = False
        lbl4OfAKind.Visible = False
        lblAddTotalOnAllDice2.Visible = False
        scoreOf4Kind.Visible = False
        lblFullHouse.Visible = False
        lblScore25.Visible = False
        scoreOfFullHouse.Visible = False
        lblSmStraight.Visible = False
        lblScore30.Visible = False
        scoreOfSmStraight.Visible = False
        lblLgStraight.Visible = False
        lblScore40.Visible = False
        scoreOfLgStraight.Visible = False
        lblYahtzee.Visible = False
        lblScore50.Visible = False
        scoreYahtzee.Visible = False
        lblChance.Visible = False
        lblScoreTotalOfAll5Dice.Visible = False
        scoreOfChance.Visible = False
        lblTotal2.Visible = False
        Arrow3.Visible = False
        total2.Visible = False
        lblGrandTotal.Visible = False
        Arrow4.Visible = False
        grandTotal.Visible = False
        RollDice.Visible = False
        highScore.Visible = False
        backButton.Visible = False
        gameOver.Visible = False
        okButton.Visible = False
        score.Visible = False
        Keep1.Visible = False
        Keep2.Visible = False
        Keep3.Visible = False
        Keep4.Visible = False
        Keep5.Visible = False
        Dice1_1.Visible = False
        Dice2_1.Visible = False
        Dice3_1.Visible = False
        Dice4_1.Visible = False
        Dice5_1.Visible = False
        Dice6_1.Visible = False
        Dice1_2.Visible = False
        Dice2_2.Visible = False
        Dice3_2.Visible = False
        Dice4_2.Visible = False
        Dice5_2.Visible = False
        Dice6_2.Visible = False
        Dice1_3.Visible = False
        Dice2_3.Visible = False
        Dice3_3.Visible = False
        Dice4_3.Visible = False
        Dice5_3.Visible = False
        Dice6_3.Visible = False
        Dice1_4.Visible = False
        Dice2_4.Visible = False
        Dice3_4.Visible = False
        Dice4_4.Visible = False
        Dice5_4.Visible = False
        Dice6_4.Visible = False
        Dice1_5.Visible = False
        Dice2_5.Visible = False
        Dice3_5.Visible = False
        Dice4_5.Visible = False
        Dice5_5.Visible = False
        Dice6_5.Visible = False

    End Sub

    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    '---------------------------Reset Values----------------------------------
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------

    Private Sub resetValues()                               'Method to reset all the values/labels/buttons

        'Reset all the values to 0
        sumOf1s = 0
        sumOf2s = 0
        sumOf3s = 0
        sumOf4S = 0
        sumOf5s = 0
        sumOf6s = 0
        totalSumOfUpperScore = 0
        bonusPoints = 0
        finalSumOfUpper = 0
        threeOfaKindScore = 0
        fourOfaKindScore = 0
        fullHouseScore = 0
        smallStraightScore = 0
        largeStraightScore = 0
        yahtzeeScore = 0
        chanceScore = 0
        totalSumOfLowerScore = 0
        finalScore = 0

        'Enabled all the labels to True
        totalOfAces.Enabled = True
        totalOfTwos.Enabled = True
        totalOfThrees.Enabled = True
        totalOfFours.Enabled = True
        totalOfFives.Enabled = True
        totalOfSixes.Enabled = True
        total1.Enabled = True
        bonusScore.Enabled = True
        scoreOf3Kind.Enabled = True
        scoreOf4Kind.Enabled = True
        scoreOfFullHouse.Enabled = True
        scoreOfSmStraight.Enabled = True
        scoreOfLgStraight.Enabled = True
        scoreYahtzee.Enabled = True
        scoreOfChance.Enabled = True
        total2.Enabled = True
        grandTotal.Enabled = True

        'Change all the back ground color back to Ghost White
        totalOfAces.BackColor = Color.GhostWhite
        totalOfTwos.BackColor = Color.GhostWhite
        totalOfThrees.BackColor = Color.GhostWhite
        totalOfFours.BackColor = Color.GhostWhite
        totalOfFives.BackColor = Color.GhostWhite
        totalOfSixes.BackColor = Color.GhostWhite
        totalsScore.BackColor = Color.GhostWhite
        bonusScore.BackColor = Color.GhostWhite
        total1.BackColor = Color.GhostWhite
        scoreOf3Kind.BackColor = Color.GhostWhite
        scoreOf4Kind.BackColor = Color.GhostWhite
        scoreOfFullHouse.BackColor = Color.GhostWhite
        scoreOfSmStraight.BackColor = Color.GhostWhite
        scoreOfLgStraight.BackColor = Color.GhostWhite
        scoreYahtzee.BackColor = Color.GhostWhite
        scoreOfChance.BackColor = Color.GhostWhite
        total2.BackColor = Color.GhostWhite
        grandTotal.BackColor = Color.GhostWhite

        'Clear the text in the labels
        totalsScore.Text = ""
        bonusScore.Text = ""
        total1.Text = ""
        total2.Text = ""
        grandTotal.Text = ""
    End Sub

End Class
