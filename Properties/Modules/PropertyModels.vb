Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes

Module PropertyModels
    Public Class PropertyM
        <BsonId>
        <BsonRepresentation(BsonType.ObjectId)>
        Public Property ID As String
        Public Property SquareMeter As Integer
        Public Property Amenities As Integer
        Public Property Description As String
        Public Property Permit As String
        Public Property EstablishDate As Date
    End Class
End Module
