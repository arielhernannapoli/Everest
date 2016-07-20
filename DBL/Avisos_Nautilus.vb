Public Class Avisos_Nautilus
    Inherits Entidad

#Region "Propiedades"
    Dim mFec_Spt As DateTime
    Dim mCad_Spt As String
    Dim mHm_Spt As Int16
    Dim mSs_Spt As Int16
    Dim mCod_Spt As Int32
    Dim mDur_Spt As Int16
    Dim mPos_Spt As Int16
    Dim mNsb_Spt As Int16
    Dim mTip_Spt As Int16
    Dim mPre_Spt As Int32
    Dim mBlk_Spt As Int16
    Dim mIdi_Spt As Int16
    Dim mPo2_Spt As Int16
    Dim mNs2_Spt As Int16
    Dim mPo3_Spt As Int16
    Dim mNs3_Spt As Int16
    Dim mNbl_Spt As Int16
    Dim mPrg_Spt As Int64
    Dim mSpr_Spt As Int32
    Dim mPpr_Spt As String
    Dim mPsp_Spt As String
    Dim mTem_Spt As Int16
    Dim mVem_Spt As Int16
    Dim mTip_Cmp As Int16
    Dim mHomoCre As Int64
    Dim mZpNomb As String
    Dim mFalla As String
    Dim mMes As Int16

    Public Property Fec_Spt() As DateTime
        Get
            Return mFec_Spt
        End Get
        Set(ByVal Value As DateTime)
            mFec_Spt = Value
        End Set
    End Property

    Public Property Cad_Spt() As String
        Get
            Return mCad_Spt
        End Get
        Set(ByVal Value As String)
            mCad_Spt = Value
        End Set
    End Property

    Public Property Hm_Spt() As Int16
        Get
            Return mHm_Spt
        End Get
        Set(ByVal Value As Int16)
            mHm_Spt = Value
        End Set
    End Property

    Public Property Ss_Spt() As Int16
        Get
            Return mSs_Spt
        End Get
        Set(ByVal Value As Int16)
            mSs_Spt = Value
        End Set
    End Property

    Public Property Cod_Spt() As Int32
        Get
            Return mCod_Spt
        End Get
        Set(ByVal Value As Int32)
            mCod_Spt = Value
        End Set
    End Property

    Public Property Dur_Spt() As Int16
        Get
            Return mDur_Spt
        End Get
        Set(ByVal Value As Int16)
            mDur_Spt = Value
        End Set
    End Property

    Public Property Pos_Spt() As Int16
        Get
            Return mPos_Spt
        End Get
        Set(ByVal Value As Int16)
            mPos_Spt = Value
        End Set
    End Property

    Public Property Nsb_Spt() As Int16
        Get
            Return mNsb_Spt
        End Get
        Set(ByVal Value As Int16)
            mNsb_Spt = Value
        End Set
    End Property

    Public Property Tip_Spt() As Int16
        Get
            Return mTip_Spt
        End Get
        Set(ByVal Value As Int16)
            mTip_Spt = Value
        End Set
    End Property

    Public Property Pre_Spt() As Int32
        Get
            Return mPre_Spt
        End Get
        Set(ByVal Value As Int32)
            mPre_Spt = Value
        End Set
    End Property

    Public Property Blk_Spt() As Int16
        Get
            Return mBlk_Spt
        End Get
        Set(ByVal Value As Int16)
            mBlk_Spt = Value
        End Set
    End Property

    Public Property Idi_Spt() As Int16
        Get
            Return mIdi_Spt
        End Get
        Set(ByVal Value As Int16)
            mIdi_Spt = Value
        End Set
    End Property

    Public Property Po2_Spt() As Int16
        Get
            Return mPo2_Spt
        End Get
        Set(ByVal Value As Int16)
            mPo2_Spt = Value
        End Set
    End Property

    Public Property Ns2_Spt() As Int16
        Get
            Return mNs2_Spt
        End Get
        Set(ByVal Value As Int16)
            mNs2_Spt = Value
        End Set
    End Property

    Public Property Po3_Spt() As Int16
        Get
            Return mPo3_Spt
        End Get
        Set(ByVal Value As Int16)
            mPo3_Spt = Value
        End Set
    End Property

    Public Property Ns3_Spt() As Int16
        Get
            Return mNs3_Spt
        End Get
        Set(ByVal Value As Int16)
            mNs3_Spt = Value
        End Set
    End Property

    Public Property Nbl_Spt() As Int16
        Get
            Return mNbl_Spt
        End Get
        Set(ByVal Value As Int16)
            mNbl_Spt = Value
        End Set
    End Property

    Public Property Prg_Spt() As Int64
        Get
            Return mPrg_Spt
        End Get
        Set(ByVal Value As Int64)
            mPrg_Spt = Value
        End Set
    End Property

    Public Property Spr_Spt() As Int32
        Get
            Return mSpr_Spt
        End Get
        Set(ByVal Value As Int32)
            mSpr_Spt = Value
        End Set
    End Property

    Public Property Ppr_Spt() As String
        Get
            Return mPpr_Spt
        End Get
        Set(ByVal Value As String)
            mPpr_Spt = Value
        End Set
    End Property

    Public Property Psp_Spt() As String
        Get
            Return mPsp_Spt
        End Get
        Set(ByVal Value As String)
            mPsp_Spt = Value
        End Set
    End Property

    Public Property Tem_Spt() As Int16
        Get
            Return mTem_Spt
        End Get
        Set(ByVal Value As Int16)
            mTem_Spt = Value
        End Set
    End Property

    Public Property Vem_Spt() As Int16
        Get
            Return mVem_Spt
        End Get
        Set(ByVal Value As Int16)
            mVem_Spt = Value
        End Set
    End Property

    Public Property Tip_Cmp() As Int16
        Get
            Return mTip_Cmp
        End Get
        Set(ByVal Value As Int16)
            mTip_Cmp = Value
        End Set
    End Property

    Public Property HomoCre() As Int64
        Get
            Return mHomoCre
        End Get
        Set(ByVal Value As Int64)
            mHomoCre = Value
        End Set
    End Property

    Public Property ZpNomb() As String
        Get
            Return mZpNomb
        End Get
        Set(ByVal Value As String)
            mZpNomb = Value
        End Set
    End Property

    Public Property Falla() As String
        Get
            Return mFalla
        End Get
        Set(ByVal Value As String)
            mFalla = Value
        End Set
    End Property

    Public Property Mes() As Int16
        Get
            Return mMes
        End Get
        Set(ByVal Value As Int16)
            mMes = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Avisos_Nautilus")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Fec_spt, Cad_spt, Hm_spt, Ss_spt, Cod_spt, Dur_spt, Pos_spt, Nsb_spt, Tip_spt, Pre_spt, Blk_spt, Idi_spt, Po2_spt, Ns2_spt, Po3_spt, Ns3_spt, Nbl_spt, Prg_spt, Spr_spt, Ppr_spt, Psp_spt, Tem_spt, Vem_spt, Tip_cmp, Homocre, Zpnomb, Falla, Mes)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Fec_spt, Cad_spt, Hm_spt, Ss_spt, Cod_spt, Dur_spt, Pos_spt, Nsb_spt, Tip_spt, Pre_spt, Blk_spt, Idi_spt, Po2_spt, Ns2_spt, Po3_spt, Ns3_spt, Nbl_spt, Prg_spt, Spr_spt, Ppr_spt, Psp_spt, Tem_spt, Vem_spt, Tip_cmp, Homocre, Zpnomb, Falla, Mes)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Fec_spt)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Fec_spt)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Fec_spt = IIf(IsDBNull(Dr("Fec_spt")), Nothing, Dr("Fec_spt"))
        Me.Cad_spt = IIf(IsDBNull(Dr("Cad_spt")), "", Dr("Cad_spt"))
        Me.Hm_spt = IIf(IsDBNull(Dr("Hm_spt")), 0, Dr("Hm_spt"))
        Me.Ss_spt = IIf(IsDBNull(Dr("Ss_spt")), 0, Dr("Ss_spt"))
        Me.Cod_spt = IIf(IsDBNull(Dr("Cod_spt")), 0, Dr("Cod_spt"))
        Me.Dur_spt = IIf(IsDBNull(Dr("Dur_spt")), 0, Dr("Dur_spt"))
        Me.Pos_spt = IIf(IsDBNull(Dr("Pos_spt")), 0, Dr("Pos_spt"))
        Me.Nsb_spt = IIf(IsDBNull(Dr("Nsb_spt")), 0, Dr("Nsb_spt"))
        Me.Tip_spt = IIf(IsDBNull(Dr("Tip_spt")), 0, Dr("Tip_spt"))
        Me.Pre_spt = IIf(IsDBNull(Dr("Pre_spt")), 0, Dr("Pre_spt"))
        Me.Blk_spt = IIf(IsDBNull(Dr("Blk_spt")), 0, Dr("Blk_spt"))
        Me.Idi_spt = IIf(IsDBNull(Dr("Idi_spt")), 0, Dr("Idi_spt"))
        Me.Po2_spt = IIf(IsDBNull(Dr("Po2_spt")), 0, Dr("Po2_spt"))
        Me.Ns2_spt = IIf(IsDBNull(Dr("Ns2_spt")), 0, Dr("Ns2_spt"))
        Me.Po3_spt = IIf(IsDBNull(Dr("Po3_spt")), 0, Dr("Po3_spt"))
        Me.Ns3_spt = IIf(IsDBNull(Dr("Ns3_spt")), 0, Dr("Ns3_spt"))
        Me.Nbl_spt = IIf(IsDBNull(Dr("Nbl_spt")), 0, Dr("Nbl_spt"))
        Me.Prg_spt = IIf(IsDBNull(Dr("Prg_spt")), 0, Dr("Prg_spt"))
        Me.Spr_spt = IIf(IsDBNull(Dr("Spr_spt")), 0, Dr("Spr_spt"))
        Me.Ppr_spt = IIf(IsDBNull(Dr("Ppr_spt")), "", Dr("Ppr_spt"))
        Me.Psp_spt = IIf(IsDBNull(Dr("Psp_spt")), "", Dr("Psp_spt"))
        Me.Tem_spt = IIf(IsDBNull(Dr("Tem_spt")), 0, Dr("Tem_spt"))
        Me.Vem_spt = IIf(IsDBNull(Dr("Vem_spt")), 0, Dr("Vem_spt"))
        Me.Tip_cmp = IIf(IsDBNull(Dr("Tip_cmp")), 0, Dr("Tip_cmp"))
        Me.Homocre = IIf(IsDBNull(Dr("Homocre")), 0, Dr("Homocre"))
        Me.Zpnomb = IIf(IsDBNull(Dr("Zpnomb")), "", Dr("Zpnomb"))
        Me.Falla = IIf(IsDBNull(Dr("Falla")), "", Dr("Falla"))
        Me.Mes = IIf(IsDBNull(Dr("Mes")), 0, Dr("Mes"))
    End Sub

    Public Overloads Function EjecutarSQL(ByVal SQL As String) As DataSet
        Return MyBase.EjecutarSQL(SQL)
    End Function
    Public Overloads Sub IniciarTransaccion()
        MyBase.IniciarTransaccion()
    End Sub

    Public Overloads Sub TerminarTransaccion()
        MyBase.TerminarTransaccion()
    End Sub

    Public Overloads Sub AbortarTransaccion()
        MyBase.AbortarTransaccion()
    End Sub

#End Region

#Region "Funciones Propias"
#End Region

End Class
