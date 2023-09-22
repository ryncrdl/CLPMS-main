Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes

Module LesseeModels
    Public Class properties
        <BsonId>
        <BsonRepresentation(BsonType.ObjectId)>
        Public Property ID As String
        Public Property propertyname As String
        Public Property lessor As String
        Public Property floors As String
        Public Property floorOcu As Int32
        Public Property userImage As String
        Public Property userEmail As String
    End Class
End Module
