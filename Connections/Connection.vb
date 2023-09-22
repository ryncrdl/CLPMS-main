Imports CLPMS.PROPERTYMANAGEMENTADD
Imports CLPMS.ADMINREGISISTRATION
Imports CLPMS.PROPERTYMANAGEMENT
Imports MongoDB.Driver
Imports CLPMS.LESSEE
Imports MongoDB.Driver.WriteConcern

Module Connection
    Public ReadOnly ConnectionString As String = "mongodb+srv://johnjericpalima11:johnjericpalima11@clpmsdb.wo66qzz.mongodb.net/CLPMSdb?retryWrites=true&w=majority"
    Private ReadOnly DatabaseName As String = "CLPMSdb"

    Private ReadOnly Client As IMongoClient = New MongoClient(ConnectionString)
    Private ReadOnly Database As IMongoDatabase = Client.GetDatabase(DatabaseName)

    Public Function GetMongoDatabase() As IMongoDatabase
        Return Database
    End Function

    Public Function IsConnected() As Boolean
        Try
            Client.ListDatabaseNames()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function GetCollectionName(Of T)() As IMongoCollection(Of T)
        Dim collectionName As String = GetType(T).Name
        Return Database.GetCollection(Of T)(collectionName)
    End Function

    'Admin  
    Public Function GetAdminsCollection() As IMongoCollection(Of Admins)
        Return GetCollectionName(Of Admins)()
    End Function

    'Property
    Public Function GetPropertiesCollection() As IMongoCollection(Of properties)
        Return GetCollectionName(Of properties)()
    End Function


    'Lesee
    Public Function GetLesseeCollection() As IMongoCollection(Of Lessee_Account)
        Return GetCollectionName(Of Lessee_Account)()
    End Function

    'Lessor
    Public Function GetLessorCollection() As IMongoCollection(Of Lessor_Account)
        Return GetCollectionName(Of Lessor_Account)()
    End Function

    'Manager
    Public Function GetMangerCollection() As IMongoCollection(Of Accounts)
        Return GetCollectionName(Of Accounts)()
    End Function


    'Archive Data


End Module
