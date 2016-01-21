﻿var gMiembrosProponentes = (function () {
    "use strict";
    var TituloForm = "";
    var gridCon = '#jqxgridMiembrosProponentes';
    var urlToGridCon = "../../Servicios/wsProponentes.asmx/GetsMiembrosProponentes";
    var urlToEliminarMiembro = "../../Servicios/wsProponentes.asmx/DeleteMiembro";
    var urlToProponente = "/Servicios/wsProponentes.asmx/Get";
    var oIdProponente;
    var oIdTercero;
    var msgPpal = "#LbMsg";

    var _addHandlers = function () {
        $("#btnVolverAtras").click(function () {
            history.back();
        });
        $("#BtnNuevo").click(function () {
            window.location.href = "MiembrosProponentes.aspx?idTerc=" + oIdTercero + "&idProp=" + oIdProponente;
        });
        $("#BtnEditar").click(function () {
            var source = gMiembrosProponentes.getRecord();
            window.location.href = "MiembrosProponentes.aspx?idTerc=" + oIdTercero + "&idProp=" + oIdProponente + "&idMiem=" + source.ID_MIEMBROS;
        });
        $("#btnEliminarMiembros").click(function () {
            var confimacion = confirm("Esta seguro de eliminar este miembro?");
            if (confimacion) {
                var source = gMiembrosProponentes.getRecord();
                _Elminar(oIdProponente, source.ID_MIEMBROS);
            }
        });
    };
    var _createElements = function () {
        $("#TituloForm").html(TituloForm);

        var sourceP = byaPage.getSource(urlToProponente, { id: "'" + oIdProponente + "'" });

        var DataFields = [
                    { Titulo: 'Id', Campo: 'ID', Tipo: 'S' },
                    { Titulo: 'Nombre', Campo: 'NOMBRE', Tipo: 'S' },
                    { Titulo: 'Adjudicado', Campo: 'ADJUDICADO', Tipo: 'S' },
                    { Titulo: 'Direción', Campo: 'DIR_PROP', Tipo: 'S' },
                    { Titulo: 'Télefono', Campo: 'TEL_PROP', Tipo: 'S' },
                    { Titulo: 'Email', Campo: 'EMA_PROP', Tipo: 'S' },    
                    //{ Titulo: 'Modalidad', Campo: 'COD_TPRO_NOM', Tipo: 'S' },
                    //{ Titulo: 'Tipo', Campo: 'TIP_CON_NOM', Tipo: 'S' },
                    //{ Titulo: 'Sub Tipo', Campo: 'STIP_CON_NOM', Tipo: 'S' },
                    //{ Titulo: 'Encargado', Campo: 'NOM_ABOG_ENC', Tipo: 'S' }
                    ////{ Titulo: 'Contratista(F)', Campo: 'NOM_CONTRATISTA', Tipo: 'S' }
        ];
        var Titulo = "INFORMACION DETALLADA DEL PROCESO";
        $('#dvdProc').DetailsJSON(sourceP, DataFields, Titulo);
        $(".Nproc").html(sourceP.NOMBRE);
    };
    var getDataAdapter = function () {
        var source = {
            datatype: "xml",
            datafields: [
	                { name: 'ID_MIEMBROS', type: 'string' },
                    { name: 'NOMBRE', type: 'string' },
                    { name: 'PORC_PART', type: 'string' },
                    { name: 'ID_ESTADO', type: 'string' }
            ],
            async: true,
            record: 'Table',
            url: urlToGridCon + "?IDE_PROP=" + oIdProponente,
            data: {}
        };
        var dataAdapter = new $.jqx.dataAdapter(source, { contentType: 'application/json; charset=utf-8' });
        return dataAdapter;
    };
    var _createGridCon = function () {
        $(gridCon).jqxGrid(
                    {
                        width: '100%',
                        source: getDataAdapter(),
                        theme: gMiembrosProponentes.config.theme,
                        localization: byaPage.getLocalization(),
                        height: 350,
                        sortable: true,
                        altrows: true,
                        showfilterrow: true,
                        filterable: true,
                        pageable: true,
                        enabletooltips: true,
                        columns: [
                        { text: 'Id', datafield: 'ID_MIEMBROS', width: 100, filtertype: 'textbox' },
                        { text: 'Nombre', datafield: 'NOMBRE', width: 300, filtertype: 'textbox' },
                        { text: 'Porcentaje (%)', datafield: 'PORC_PART', width: 150, filtertype: 'textbox' },
                        { text: 'Estado', datafield: 'ID_ESTADO', width: 70, filtertype: 'textbox' }
                        ]
                    });

    };
    var _Elminar = function (idProponente, idMiembro) {
        var parametrosJSON = {
            "IDE_PROP": idProponente,
            "ID_MIEMBROS":idMiembro
        };
        $.ajax({
            type: "GET",
            url: urlToEliminarMiembro,
            data: parametrosJSON,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            async: false,
            beforeSend: function () {
                $(msgPpal).msgBox({ titulo: "Miembros Proponentes", mensaje: "Procesando.. espere por favor...!!!", tipo: "info" });
            },
            success: function (result) {
                var e = byaPage.retObj(result.d);
                if (e.Error == false) {
                    _createGridCon();
                }
                $(msgPpal).msgBox({ titulo: "Miembro", mensaje: e.Mensaje, tipo: "warning" });
            },
            error: function (jqXHR, status, error) {
                alert(error + "-" + jqXHR.responseText);
            }
        });
    };

    return {
        editedRows: null,
        config: {
            dragArea: null,
            theme: null
        },
        getRecord: function () {
            var selectedrowindex = $(gridCon).jqxGrid('getselectedrowindex');
            var dataRecord = $(gridCon).jqxGrid('getrowdata', selectedrowindex);
            //alert(JSON.stringify(dataRecord));
            return dataRecord;
        },
        refresh: function () {
            $(gridCon).jqxGrid({ source: getDataAdapter() });
        },
        init: function () {
            oIdProponente = $.getUrlVar('idProp');
            oIdTercero = $.getUrlVar('idTerc');
            _createElements();
            _addHandlers();
            _createGridCon();
        }
    };
}());

$(function () {
    byaSite.SetModuloP({ TituloForm: "Miembros", Modulo: "Gestion", urlToPanelModulo: "gPproponentes.aspx", Cod_Mod: "SOLI4", Rol: "PR_RECEP" });
    gMiembrosProponentes.config.theme = byaSite.tema
    gMiembrosProponentes.init();
});