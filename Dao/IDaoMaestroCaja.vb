Imports EfectiOro.Database

Public Interface IDaoMaestroCaja

    ''' <summary>
    ''' Revisa si la caja quedó abierta del dia anterior, True si es el mismo Dia, False si no lo es
    ''' </summary>
    ''' <param name="caja">Caja actual</param>
    ''' <returns>True si esl mismo Dia, False si no lo es</returns>
    ''' <remarks></remarks>
    Function validarCajaAbierta(ByVal caja As String) As Boolean

    ''' <summary>
    ''' Recuperar los saldos en caja
    ''' </summary>
    ''' <param name="caja"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function recuperarSaldoCaja(ByVal caja As String) As Mcaja
    ''' <summary>
    ''' Estado de la caja actual
    ''' </summary>
    ''' <param name="caja"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function estadoCaja(ByVal caja As String) As Boolean
    ''' <summary>
    ''' Abrir caja actual
    ''' </summary>
    ''' <param name="caja"></param>
    ''' <param name="agencia"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function abrirCaja(ByVal caja As String, agencia As String) As Boolean
    ''' <summary>
    ''' Cerrar caja actual
    ''' </summary>
    ''' <param name="caja"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function cerrarCaja(ByVal caja As String) As Boolean
    ''' <summary>
    ''' Actualizar el maestro de caja
    ''' </summary>
    ''' <param name="mocaja"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function actualizarDatosMaestroCaja(mocaja As Mcaja) As Boolean
    ''' <summary>
    ''' Guardar el movimiento de caja en el detalle de caja
    ''' </summary>
    ''' <param name="dcaja"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function guardarDatosDetaCaja(dcaja As Detacaja, mocaja As Mcaja) As Boolean
    ''' <summary>
    ''' Validar movimiento si es entrada o salida
    ''' </summary>
    ''' <param name="idmov">Integer</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Function validarMovimiento(idmov As Integer) As Boolean
    ''' <summary>
    ''' Lista de todos los movimientos realizados en la caja
    ''' </summary>
    ''' <param name="caja"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function listarDetaCaja(caja As String) As List(Of Detacaja)
    Function validarPrestamosPuentes() As Decimal
    ''' <summary>
    ''' Recuperamos los valores de: Efectivo, Cheque, Trnasferencia; siempre que la caja este abierta.
    ''' </summary>
    ''' <param name="mcaja"></param>
    ''' <returns></returns>
    Function recuperarDetaCajaValores(mcaja As Mcaja) As List(Of Decimal)
    ''' <summary>
    ''' Manejar los errores
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property ErrorSms As String
End Interface
