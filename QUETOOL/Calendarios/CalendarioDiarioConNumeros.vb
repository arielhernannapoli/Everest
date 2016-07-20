Namespace Calendarios
    Public MustInherit Class CalendarioDiarioConNumeros
        Inherits CalendarioDiario

        Protected SpotsTotales As DataTable

        Protected MustOverride Sub ObtenerDatosTotalesCalendario()
    End Class
End Namespace
