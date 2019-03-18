Public Class Dossier

    Private civilite As String
    Private nom As String
    Private prenom As String
    Private dateNaissance As DateTime
    Private adresse As String
    Private codePostal As Integer
    Private ville As String
    Private pays As String
    Private statut As String
    Private niveauEtudes As String
    Private autre As String
    Private profession As String
    Private domaineEmploi As String
    Private mailPerso As String
    Private mailPro As String
    Private telPerso As Integer
    Private telPro As Integer
    Private cvOuiNon As Boolean
    Private lettreMotivationOuiNon As Boolean
    Private dateDebutContrat As DateTime
    Private dateFinContrat As DateTime
    Private accompteVerseOuiNon As Boolean
    Private numeroCheque As Integer
    Private typeFinancement As String
    Private fidelite As String

    Sub New()
        'Constructeur
    End Sub

    'Famille des get

    Private Function getCivilite()
        Return civilite
    End Function

    Private Function getNom()
        Return nom
    End Function

    Private Function getPrenom()
        Return prenom
    End Function

    Private Function getDateNaissance()
        Return dateNaissance
    End Function

    Private Function getAdresse()
        Return adresse
    End Function

    Private Function getCodePostal()
        Return codePostal
    End Function

    Private Function getVille()
        Return ville
    End Function

    Private Function getPays()
        Return pays
    End Function

    Private Function getStatut()
        Return statut
    End Function

    Private Function getNiveauEtude()
        Return niveauEtudes
    End Function

    Private Function getAutre()
        Return autre
    End Function

    Private Function getProfession()
        Return profession
    End Function

    Private Function getDomaineEmploi()
        Return domaineEmploi
    End Function

    Private Function getMailPerso()
        Return mailPerso
    End Function

    Private Function getMailPro()
        Return mailPro
    End Function

    Private Function getTelPerso()
        Return telPerso
    End Function

    Private Function getTelPro()
        Return telPro
    End Function

    Private Function getCV()
        Return cvOuiNon
    End Function

    Private Function getLettreMotivation()
        Return lettreMotivationOuiNon
    End Function

    Private Function getDateDebutContrat()
        Return dateDebutContrat
    End Function

    Private Function getDateFinContrat()
        Return dateFinContrat
    End Function

    Private Function getAccompte()
        Return accompteVerseOuiNon
    End Function

    Private Function getNumeroCheque()
        Return numeroCheque
    End Function

    Private Function getTypeFinancement()
        Return typeFinancement
    End Function

    Private Function getFidelite()
        Return fidelite
    End Function

    'Famille des get

    'Private Function setCivilite(chercher syntaxe lundi)


End Class
