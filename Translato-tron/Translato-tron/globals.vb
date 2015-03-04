Public Class GlobalVariables
    Public Shared Property CurrentCountry As String
    Public Shared Property English As New Dictionary(Of Integer, String) From {
        {1, "What is your name?"},
        {2, "My name is..."},
        {3, "Where can I find something to eat?"},
        {4, "Where is the train station?"},
        {5, "Where is the airport?"},
        {6, "Can you show me the nearest toilet?"},
        {7, "Hello"},
        {8, "Goodbye"},
        {9, "Thank you"},
        {10, "I'm from..."}
    }
    Public Shared Property Danish As New Dictionary(Of Integer, String) From {
        {1, "Hvad er dit navn?"},
        {2, "Mit navn er"},
        {3, "Hvor kan jeg finde noget at spise?"},
        {4, "Hvor er stationen?"},
        {5, "Hvor er lufthavnen?"},
        {6, "Kan du vise mig det nærmeste toilet?"},
        {7, "Hej"},
        {8, "Farvel"},
        {9, "Tak"},
        {10, "Jeg er fra"}
    }
    Public Shared Property French As New Dictionary(Of Integer, String) From {
        {1, "Quel est votre nom?"},
        {2, "Mon nom est"},
        {3, "Où puis-je trouver quelque chose à manger?"},
        {4, "Où est la gare?"},
        {5, "Où est l'aéroport?"},
        {6, "Pouvez-vous me montrer la toilette la plus proche?"},
        {7, "Bonjour"},
        {8, "Au revoir"},
        {9, "Merci"},
        {10, "Je suis de"}
    }
    Public Shared Property Bosnian As New Dictionary(Of Integer, String) From {
        {1, "Koje je vaše ime?"},
        {2, "Moje ime je"},
        {3, "Gdje mogu naći nešto za jelo?"},
        {4, "Gdje je željezničke stanice?"},
        {5, "Gdje je zračna luka?"},
        {6, "Možeš li mi najbližeg toalet pokazati?"},
        {7, "Zdravo"},
        {8, "Zbogom"},
        {9, "Hvala"},
        {10, "Ja sam iz"}
    }
End Class
