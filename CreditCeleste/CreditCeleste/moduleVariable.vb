Module moduleVariable
    Public fenIntro As frmIntroduction  ''accessible à tout le monde

    Public fenSaisieBien As frmSaisieBien  ''accessible à tout le monde

    Public uneConcession As Concession    'Dans tous les cas, la concession doit être créée 

    Public uneVoiture As New Voiture     'Dans tous les cas, la voiture doit être créée 
    ''la voiture appartient au client


    'Le client avec sa voiture
    '
    Public unClientVoiture As New ClientVoit

    Public fenCredit As New frmCredit  'accessible à tout le monde

    Public unCredit As New Credit

    Public fenClient As New Client
End Module
