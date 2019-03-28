Public Class Dossier


    Sub New()
        'Constructeur
    End Sub

    Private civilite As String
    Public Property p_civilite() As String
        Get
            Return civilite
        End Get
        Set(ByVal value As String)
            civilite = value
        End Set
    End Property

    Private nom As String
    Public Property p_nom() As String
        Get
            Return nom
        End Get
        Set(ByVal value As String)
            nom = value
        End Set
    End Property

    Private prenom As String
    Public Property p_prenom() As String
        Get
            Return prenom
        End Get
        Set(ByVal value As String)
            prenom = value
        End Set
    End Property

    Private dateNaissance As Date
    Public Property p_dateNaissance() As Date
        Get
            Return dateNaissance
        End Get
        Set(ByVal value As Date)
            dateNaissance = value
        End Set
    End Property

    Private adresse As String
    Public Property p_adresse() As String
        Get
            Return adresse
        End Get
        Set(ByVal value As String)
            adresse = value
        End Set
    End Property

    Private complementAdresse As String
    Public Property p_complementAdresse() As String
        Get
            Return complementAdresse
        End Get
        Set(ByVal value As String)
            complementAdresse = value
        End Set
    End Property

    Private codePostal As Integer
    Public Property p_codePostal() As Integer
        Get
            Return codePostal
        End Get
        Set(ByVal value As Integer)
            codePostal = value
        End Set
    End Property

    Private ville As String
    Public Property p_ville() As String
        Get
            Return ville
        End Get
        Set(ByVal value As String)
            ville = value
        End Set
    End Property

    Private pays As String
    Public Property p_pays() As String
        Get
            Return pays
        End Get
        Set(ByVal value As String)
            pays = value
        End Set
    End Property

    Private statut As String
    Public Property p_statut() As String
        Get
            Return statut
        End Get
        Set(ByVal value As String)
            statut = value
        End Set
    End Property

    Private niveauEtudes As String
    Public Property p_niveauEtudes() As String
        Get
            Return niveauEtudes
        End Get
        Set(ByVal value As String)
            niveauEtudes = value
        End Set
    End Property

    Private profession As String
    Public Property p_profession() As String
        Get
            Return profession
        End Get
        Set(ByVal value As String)
            profession = value
        End Set
    End Property

    Private domaineEmploi As String
    Public Property p_domaineEmploi() As String
        Get
            Return domaineEmploi
        End Get
        Set(ByVal value As String)
            domaineEmploi = value
        End Set
    End Property

    Private mailPerso As String
    Public Property p_mailPerso() As String
        Get
            Return mailPerso
        End Get
        Set(ByVal value As String)
            mailPerso = value
        End Set
    End Property

    Private mailPro As String
    Public Property p_mailPro() As String
        Get
            Return mailPro
        End Get
        Set(ByVal value As String)
            mailPro = value
        End Set
    End Property

    Private telPro As Integer
    Public Property p_telPro() As Integer
        Get
            Return telPro
        End Get
        Set(ByVal value As Integer)
            telPro = value
        End Set
    End Property

    Private telPerso As Integer
    Public Property p_telPerso() As Integer
        Get
            Return telPerso
        End Get
        Set(ByVal value As Integer)
            telPerso = value
        End Set
    End Property

    Private cvOuiNon As Boolean
    Public Property p_cvOuiNon() As Boolean
        Get
            Return cvOuiNon
        End Get
        Set(ByVal value As Boolean)
            cvOuiNon = value
        End Set
    End Property

    Private lettreMotivationOuiNon As Boolean
    Public Property p_lettreMotivationOuiNon() As Boolean
        Get
            Return lettreMotivationOuiNon
        End Get
        Set(ByVal value As Boolean)
            lettreMotivationOuiNon = value
        End Set
    End Property

    Private dateDebutContrat As Date
    Public Property p_dateDebutContrat() As Date
        Get
            Return dateDebutContrat
        End Get
        Set(ByVal value As Date)
            dateDebutContrat = value
        End Set
    End Property

    Private dateFinContrat As Date
    Public Property p_dateFinContrat() As Date
        Get
            Return dateFinContrat
        End Get
        Set(ByVal value As Date)
            dateFinContrat = value
        End Set
    End Property

    Private acompteOuiNon As Boolean
    Public Property p_acompteOuiNon() As Boolean
        Get
            Return acompteOuiNon
        End Get
        Set(ByVal value As Boolean)
            acompteOuiNon = value
        End Set
    End Property

    Private numeroCheque As String
    Public Property p_numeroCheque() As String
        Get
            Return numeroCheque
        End Get
        Set(ByVal value As String)
            numeroCheque = value
        End Set
    End Property

    Private financement As String
    Public Property p_financement() As String
        Get
            Return financement
        End Get
        Set(ByVal value As String)
            financement = value
        End Set
    End Property

    Private fidelite As String
    Public Property p_fidelite() As String
        Get
            Return fidelite
        End Get
        Set(ByVal value As String)
            fidelite = value
        End Set
    End Property

End Class
