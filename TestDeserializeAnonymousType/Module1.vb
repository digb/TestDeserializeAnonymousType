Imports Newtonsoft.Json

Module Module1

    Sub Main()
        Dim exampleJsonString = "{ ""UserId"": ""admin"", ""CompanyId"": ""XYZ"" }"

        Dim definition = New With {.CompanyId = String.Empty}

        Dim oPayload = JsonConvert.DeserializeAnonymousType(exampleJsonString, definition)

        Console.WriteLine(oPayload.CompanyId)
        Console.ReadKey(True)
    End Sub

End Module
