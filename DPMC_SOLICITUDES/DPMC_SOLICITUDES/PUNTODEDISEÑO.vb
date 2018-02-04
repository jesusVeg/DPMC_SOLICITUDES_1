Public Class form_puntodediseño
    Private Sub ft_button_registrar_Click(sender As Object, e As EventArgs) Handles ft_button_registrar.Click
        'Definir objetos a utilizar
        Dim N_Informe As Integer
        Dim wbDestino As Object
        Dim wsOrigen As Object
        Dim wsDestino As Object
        Dim rngOrigen As Object
        Dim rngDestino As Object

        Windows("registroclientes-3 (semifinal).xlsm").Activate
        Sheets("DATA").Select
        fecha = Range("H7").value
        rol = Range("H8").value
        tiposolicitud = Range("H9").value
        spo = Range("J12").value
        expediente = Range("J13").value
        cliente = Range("J14").value
        direccionobra = Range("J15").value
        distritoobra = Range("J16").value
        provinciaobra = Range("J17").value
        empresasolic = Range("J19").value
        direccionevio = Range("J20").value
        distritoenvio = Range("J21").value
        potenciamt = Range("J22").value
        potenciabt = Range("J23").value
        dpd = Range("J24").value
        servidumbre = Range("J25").value
        tarifasolicitada = Range("J27").value
        potenciaexistente = Range("J28").value
        tarifaexistente = Range("J29").value
        suministroexistente = Range("J30").value
        alimentador = Range("J31").value
        tension = Range("J32").value
        conexion = Range("J33").value
        nodoinicial = Range("J34").value
        nodofinal = Range("J35").value
        sedreferencia = Range("J36").value
        pcc10 = Range("J37").value
        pcc22 = Range("J38").value
        puntoanterior = Range("J39").value
        fechaanterior = Range("J40").value
        dpdpunto = Range("J41").value
        celdapunto = Range("J42").value
        memorevision = Range("J43").value
        estadorevision = Range("J44").value
        obs1 = Range("J45").value
        obs2 = Range("J46").value
        obs3 = Range("J47").value
        obs4 = Range("J48").value
        obs5 = Range("J49").value
        obs6 = Range("J50").value
        spopuntovigente = Range("J51").value
        cantidadplanos = Range("J52").value
        potenciainstalada = Range("J53").value
        memoconformidad = Range("J54").value
        proyectistact = Range("J55").value
        cipct = Range("J56").value
        celular = Range("P44").value
        contacto = Range("P45").value
        crlds = Range("P46").value
        etapa = Range("P47").value
        nrevision = Range("J51").value
        tiporevision = Range("J52").value
        ninforme = Range("H10").value 'ninforme
        tarifasol = Range("J27").value 'tarifa solicitada
        potenciaexist = Range("J28").value 'potencia existente
        tarifaexist = Range("J29").value 'tarifa existente
        nsuministro = Range("J30").value 'n suministro

        alimentadorpa = Range("J31").value 'alimentador
        tensionpa = Range("J32").value 'tension
        tipoconexion = Range("J33").value 'tipoconexion
        nodoi = Range("J34").value 'nodoinicial
        nodof = Range("J35").value 'nodofinal
        sedref = Range("J36").value 'sedreferencia
        pcc10 = Range("J37").value 'Pcc10
        pcc22 = Range("J38").value 'Pcc22.9
        puntoant = Range("J39").value 'nspopuntoanterior
        fechant = Range("J40").value 'fechapuntoanterior
        dpdpunto = Range("J41").value 'dpd punto
        ncelda = Range("J42").value 'n celda
        callebt = Range("P51").value 'calle bt
        extremobt = Range("P52").value 'extremo
        servidumbreubicacion = Range("P53").value 'ubicacion area servidumbre

'Indicar el libro de Excel destino
Set wbDestino = Workbooks.Open("Z:\MT\Contrlol de solicitudes\BASECLIENTES_DPMC2018.xlsm")
Sheets("BASE").Select

        i = ActiveSheet.Cells(Rows.Count, "A").End(xlUp).Row

        Range("A" & i + 1).value = spo 'SPO
        Range("B" & i + 1).value = expediente 'EXP
        Range("C" & i + 1).value = cliente 'CLIENTE
        Range("D" & i + 1).value = crlds ' 'CR
        Range("E" & i + 1).value = rol 'ROL
        Range("F" & i + 1).value = etapa 'ETAPA
        Range("G" & i + 1).value = tiposolicitud 'TIPO SOLICITUD
        Range("H" & i + 1).value = celular 'CELULAR
        Range("I" & i + 1).value = contacto 'CONTACTO
        Range("J" & i + 1).value = fecha 'FECHA
        Range("K" & i + 1).value = direccionobra 'DIRECCION OBRA
        Range("L" & i + 1).value = distritoobra 'DISTRITO
        Range("M" & i + 1).value = provinciaobra 'PROVINCIA OBRA
        Range("N" & i + 1).value = empresasolic 'PROVINCIA OBRA
        Range("O" & i + 1).value = direccionevio 'PROVINCIA OBRA
        Range("P" & i + 1).value = distritoenvio 'PROVINCIA OBRA
        Range("Q" & i + 1).value = potenciamt 'PROVINCIA OBRA
        Range("R" & i + 1).value = potenciabt 'PROVINCIA OBRA
        Range("S" & i + 1).value = dpd 'PROVINCIA OBRA
        Range("T" & i + 1).value = servidumbre 'PROVINCIA OBRA
        Range("AO" & i + 1).value = memorevision 'PROVINCIA OBRA
        Range("AP" & i + 1).value = nrevision 'PROVINCIA OBRA
        Range("AQ" & i + 1).value = tiporevision 'PROVINCIA OBRA
        Range("AR" & i + 1).value = estadorevision 'PROVINCIA OBRA
        Range("AS" & i + 1).value = obs1 'PROVINCIA OBRA
        Range("AT" & i + 1).value = obs2 'PROVINCIA OBRA
        Range("AU" & i + 1).value = obs3 'PROVINCIA OBRA
        Range("AV" & i + 1).value = obs4 'PROVINCIA OBRA
        Range("AW" & i + 1).value = obs5 'PROVINCIA OBRA
        Range("AX" & i + 1).value = obs6 'PROVINCIA OBRA

        Range("U" & i + 1).value = ninforme
        Range("V" & i + 1).value = tarifasol
        Range("W" & i + 1).value = potenciaexist
        Range("X" & i + 1).value = tarifaexist 'tarifa existente
        Range("Y" & i + 1).value = nsuministro 'n suministro

        Range("AB" & i + 1).value = alimentadorpa 'alimentador
        Range("AD" & i + 1).value = tensionpa 'tension
        Range("AE" & i + 1).value = tipoconexion 'tipoconexion
        Range("AF" & i + 1).value = nodoi 'nodoinicial
        Range("AG" & i + 1).value = nodof 'nodofinal
        Range("AC" & i + 1).value = sedref 'sedreferencia
        Range("Z" & i + 1).value = pcc10 'Pcc10
        Range("AA" & i + 1).value = pcc22 'Pcc22.9
        Range("AH" & i + 1).value = puntoant 'nspopuntoanterior
        Range("AI" & i + 1).value = fechant 'fechapuntoanterior
        Range("AJ" & i + 1).value = dpdpunto 'dpd punto
        Range("AK" & i + 1).value = ncelda 'n celda
        Range("AL" & i + 1).value = callebt 'calle bt
        Range("AM" & i + 1).value = extremobt 'extremo
        Range("AN" & i + 1).value = servidumbreubicacion 'ubicacion area servidumbre



        wbDestino.Save
        wbDestino.Close

        'Vuelve a la hoja Data
        Sheets("DATA").Select
    End Sub
End Class