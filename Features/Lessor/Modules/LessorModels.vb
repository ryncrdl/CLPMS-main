Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes

Module LessorModel
    Public Class Lessor_Account
        <BsonId>
        <BsonRepresentation(BsonType.ObjectId)>
        Public Property ID As String

        Public Property fullname As String
        Public Property email As String
        Public Property password As String
        Public Property gender As String

    End Class
End Module
