﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defaul.aspx.cs" Inherits="wfSircc.Defaul" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta name="description" content="3 styles with inline editable feature" />
		<meta name="viewport" content="width=device-width, initial-scale=1.0" />

        <link href="Content/bootstrap/bootstrap.css" rel="stylesheet" />
		<!-- basic styles -->

		<link href="/Content/aceadmin/css/bootstrap.min.css" rel="stylesheet" />
		<link rel="stylesheet" href="/Content/aceadmin/css/font-awesome.min.css" />
        <%--<link href="/Content/font-awesome-4.2.0/css/font-awesome.min.css" rel="stylesheet" />--%>
		<!--[if IE 7]>
		  <link rel="stylesheet" href="/Content/aceadmin/css/font-awesome-ie7.min.css" />
		<![endif]-->

		<!-- page specific plugin styles -->

		<link rel="stylesheet" href="/Content/aceadmin/css/jquery-ui-1.10.3.custom.min.css" />
	
		<!-- fonts -->

		<link rel="stylesheet" href="/Content/aceadmin/css/ace-fonts.css" />

		<!-- ace styles -->

		<link rel="stylesheet" href="/Content/aceadmin/css/ace.min.css" />
		<link rel="stylesheet" href="/Content/aceadmin/css/ace-rtl.min.css" />
		<link rel="stylesheet" href="/Content/aceadmin/css/ace-skins.min.css" />

		<!--[if lte IE 8]>
		  <link rel="stylesheet" href="/Content/aceadmin/css/ace-ie.min.css" />
		<![endif]-->

		<!-- inline styles related to this page -->
        <script src="/Scripts/jquery-1.9.1.js"></script>
		<!-- ace settings handler -->
         
		<script src="/Content/aceadmin/js/ace-extra.min.js"></script>

		<!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->

		<!--[if lt IE 9]>
		<script src="/Content/aceadmin/js/html5shiv.js"></script>
		<script src="/Content/aceadmin/js/respond.min.js"></script>
		<![endif]-->

</head>
<body>
    <form id="form1" runat="server">

        
    <section class="grigio">
        <div class="container">
            <div class="presentazione">
            <h2>SIRCC &reg - </h2>
            <p>SISTEMA DE INFORMACIÓN DE RADICACIÓN Y CONTROL DE CONTRATOS.</p>
          </div>

            <div class="row">
                <div class="col-sm-4">
                    <div class="media">
                        <div class="row ">
                            <div class="media-img  pull-left  col-sm-5  col-md-4 ">
                                <div class="img-overlay "><a class="btn  btn-primary  animated fadeInUp " href="/en/about/" rel="bookmark">Open</a> </div>
                                <img src="http://riotdesign.eu/en/assets/img/links-about.jpg" alt="About" width="150" height="150">
                            </div>
                            <div class="media-body   col-sm-7 col-md-8  ">
                                <h4 class="media-heading"><a href="/about/">Estudios Previos</a></h4>
                                <p class="hidden-sm">Diligenciar, Revisar y Aprobar </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="media">
                        <div class="row ">
                            <div class="media-img pull-left   col-sm-5 col-md-4 ">
                        <div class="img-overlay  "><a class="btn  btn-primary  animated fadeInUp needsclick" href="/en/portfolio/" rel="bookmark">Open</a> </div>
                        <img src="/assets/img/links-portfolio.jpg" alt="Web Design and Graphic Design Portfolio" width="150" height="150">
                    </div>
                            <div class="media-body   col-sm-7  col-md-8 ">
                                <h4 class="media-heading"><a href="/en/portfolio/">Solicitudes </a></h4>
                                <p class="hidden-sm">Recepcioón de Solicitudes, Asignación</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="media">
                        <div class="row ">
                            <div class="media-img pull-left   col-sm-5 col-md-4 ">
                        <div class="img-overlay  "><a class="btn  btn-primary  animated fadeInUp needsclick" href="/en/portfolio/" rel="bookmark">Open</a> </div>
                        <img src="/assets/img/links-portfolio.jpg" alt="Web Design and Graphic Design Portfolio" width="150" height="150">
                    </div>
                            <div class="media-body   col-sm-7  col-md-8 ">
                                <h4 class="media-heading"><a href="/en/portfolio/">Procesos</a></h4>
                                <p class="hidden-sm"> Recepción, Revisión, Cronograma</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4">
                    <div class="media">
                        <div class="row ">
                            <div class="media-img  pull-left   col-sm-5 col-md-4 ">
                        <div class="img-overlay "><a class="btn  btn-primary  animated fadeInUp needsclick" href="/en/contacts/" rel="bookmark">Open</a> </div>
                        <img src="/assets/img/links-contatti.jpg" alt="Contacts for our agency in Empoli, Florence (Italy)" width="150" height="150">
                    </div>
                            <div class="media-body  col-sm-7 col-md-8 ">
                                <h4 class="media-heading"><a href="/en/contacts/">Contratación</a></h4>
                                <p class="hidden-sm"> Radicación, Legalización, Documentos</p>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-sm-4">
                    <div class="media">
                        <div class="row ">
                            <div class="media-img  pull-left  col-sm-5  col-md-4 ">
                        <div class="img-overlay "><a class="btn  btn-primary  animated fadeInUp " href="/en/about/" rel="bookmark">Open</a> </div>
                        <img src="http://riotdesign.eu/en/assets/img/links-about.jpg" alt="About" width="150" height="150">
                    </div>
                            <div class="media-body   col-sm-7 col-md-8  ">
                                <h4 class="media-heading"><a href="/about/">Contratista</a></h4>
                                <p class="hidden-sm">Contratos Vigentes, Informes</p>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-sm-4">
                    <div class="media">
                        <div class="row ">
                            <div class="media-img pull-left   col-sm-5 col-md-4 ">
                        <div class="img-overlay  "><a class="btn  btn-primary  animated fadeInUp needsclick" href="/en/portfolio/" rel="bookmark">Open</a> </div>
                        <img src="/assets/img/links-portfolio.jpg" alt="Web Design and Graphic Design Portfolio" width="150" height="150">
                    </div>
                            <div class="media-body   col-sm-7  col-md-8 ">
                                <h4 class="media-heading"><a href="/en/portfolio/">Supervisor</a></h4>
                                <p class="hidden-sm">Revisión de Informes, elaboración de actas.</p>
                            </div>
                        </div>
                    </div>
                </div>
                </div>
            <div class="row">
                <div class="col-sm-4">
                    <div class="media">
                        <div class="row ">
                            <div class="media-img  pull-left   col-sm-5 col-md-4 ">
                            <div class="img-overlay "><a class="btn  btn-primary  animated fadeInUp needsclick" href="/en/contacts/" rel="bookmark">Open</a> </div>
                            <img src="/assets/img/links-contatti.jpg" alt="Contacts for our agency in Empoli, Florence (Italy)" width="150" height="150">
                        </div>
                            <div class="media-body  col-sm-7 col-md-8 ">
                                <h4 class="media-heading"><a href="/en/contacts/">Contabilidad</a></h4>
                                <p class="hidden-sm">Recepción, Revisón de Cuentas</p>
                            </div>
                        </div>
                    </div>
                </div>
                
                 <div class="col-sm-4">
                    <div class="media">
                        <div class="row ">
                            <div class="media-img  pull-left   col-sm-5 col-md-4 ">
                        <div class="img-overlay "><a class="btn  btn-primary  animated fadeInUp needsclick" href="/en/contacts/" rel="bookmark">Open</a> </div>
                        <img src="http://placehold.it/1900x1080&text=Tesoreria" alt="Contacts for our agency in Empoli, Florence (Italy)" width="150" height="150">
                    </div>
                            <div class="media-body  col-sm-7 col-md-8 ">
                                <h4 class="media-heading"><a href="/en/contacts/">Tesoreria</a></h4>
                                <p class="hidden-sm">Recepción, Revisón y Pagos</p>
                            </div>
                        </div>
                    </div>
                </div>

                 <div class="col-sm-4">
                    <div class="media">
                        <div class="row ">
                            <div class="media-img  pull-left   col-sm-5 col-md-4 ">
                        <div class="img-overlay "><a class="btn  btn-primary  animated fadeInUp needsclick" href="/en/contacts/" rel="bookmark">Open</a> </div>
                        <img src="https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcR9T_2yEYBnGx0d-VuubfN8qiq9_vCDYP4EMNwMzZExDUjIJMpR" alt="Contacts for our agency in Empoli, Florence (Italy)" width="150" height="150">
                    </div>
                            <div class="media-body  col-sm-7 col-md-8 ">
                                <h4 class="media-heading"><a href="/en/contacts/">Archivo</a></h4>
                                <p class="hidden-sm">Archivo y Cierre</p>
                            </div>
                        </div>
                    </div>
                </div>
                </div>

            </div>
        
    </section>

    <hr />

        
    

    <style>
        /*Rd3 - Riot Design 2013
Realizzato da Paolo Marchetti @ Riot Design*/


        /* ==========================================================================
   Base
   ========================================================================== */


        html
        {
            /* 	-webkit-font-smoothing: antialiased; */
        }



        body
        {
            background: #424b51;
        }

        h1
        {
            font-family: "Museo300Regular", Helvetica, Arial, sans-serif;
            font-size: 36px;
            font-weight: normal;
        }

        h2
        {
            font-family: "Museo300Regular", Helvetica, Arial, sans-serif;
            font-size: 28px;
            font-weight: normal;
        }

        h3
        {
            font-family: "Museo300Regular", Helvetica, Arial, sans-serif;
            font-size: 22px;
            font-weight: normal;
        }

        h4
        {
            font-size: 19px;
            font-weight: 700;
            text-transform: uppercase;
        }

        h5
        {
            font-size: 16px;
            font-weight: 700;
        }

        h6
        {
            font-size: 13px;
            font-weight: 700;
            text-transform: none;
            letter-spacing: 1px;
        }

        p
        {
            margin-bottom: 1em;
        }

        .btn-primary.disabled,
        .btn-primary[disabled],
        fieldset[disabled] .btn-primary,
        .btn-primary.disabled:hover,
        .btn-primary[disabled]:hover,
        fieldset[disabled] .btn-primary:hover,
        .btn-primary.disabled:focus,
        .btn-primary[disabled]:focus,
        fieldset[disabled] .btn-primary:focus,
        .btn-primary.disabled:active,
        .btn-primary[disabled]:active,
        fieldset[disabled] .btn-primary:active,
        .btn-primary.disabled.active,
        .btn-primary[disabled].active,
        fieldset[disabled] .btn-primary.active
        {
            background-color: transparent;
        }

        /* =============================================================================
   Header
   
  ========================================================================== */




        .logged-in .navbar-fixed-top
        {
            top: 28px;
        }

        .navbar .navbar-inner
        {
            background: none;
            border: none;
            padding: 0;
        }

        .navbar-inner > .container
        {
            position: relative;
            margin-top: 50px;
            -webkit-transition: all 0.2s ease-out; /* Chrome 1-25, Safari 3.2+ */
            -moz-transition: all 0.2s ease-out; /* Firefox 4-15 */
            -o-transition: all 0.2s ease-out; /* Opera 10.50–12.00 */
            transition: all 0.2s ease-out; /* Chrome 26, Firefox 16+, IE 10+, Opera 12.10+ */
        }

        .banner
        {
            z-index: 100;
            width: 100%;
            border: none;
            background: transparent;
            position: fixed;
        }

        .navbar .brand
        {
            position: absolute;
            bottom: 15px;
            background: url(../img/rd-logo-bianco.png) no-repeat;
            width: 124px;
            height: 64px;
            background-size: 100%;
            text-indent: -9999px;
            display: block;
            margin: 0;
            margin-top: 5px;
            padding: 0;
            position: absolute;
            -webkit-transition: opacity 0.1s ease-out; /* Chrome 1-25, Safari 3.2+ */
            -moz-transition: opacity 0.1s ease-out; /* Firefox 4-15 */
            -o-transition: opacity 0.1s ease-out; /* Opera 10.50–12.00 */
            transition: opacity 0.1s ease-out; /* Chrome 26, Firefox 16+, IE 10+, Opera 12.10+ */
        }

        .navbar .brand-piccolo
        {
            display: none;
            opacity: 0;
            filter: alpha(opacity=0);
            position: absolute;
            background: url(../img/rd-logo-bianco.png) no-repeat;
            width: 73px;
            height: 40px;
            top: 6px;
            background-size: 100%;
            text-indent: -9999px;
            display: block;
            margin: 0;
            margin-top: 0;
            padding: 0;
            position: absolute;
        }

        .navbar-default .navbar-toggle
        {
            margin-right: 0;
            border-color: #fff;
            margin-top: 8px;
            margin-bottom: 8px;
        }

            .navbar-default .navbar-toggle .icon-bar
            {
                background-color: #fff;
            }

            .navbar-default .navbar-toggle:hover,
            .navbar-default .navbar-toggle:focus
            {
                background-color: #fff;
            }

                .navbar-default .navbar-toggle:hover .icon-bar,
                .navbar-default .navbar-toggle:focus .icon-bar
                {
                    background-color: #363635;
                }

        .navbar-collapse
        {
            clear: both;
            border: none;
            padding: 0;
        }

        .navbar .nav li a
        {
            text-transform: uppercase;
            font-size: 13px;
            font-weight: 700;
            letter-spacing: 1px;
            opacity: 0.65;
            filter: alpha(opacity=65);
            display: block;
            background: rgba(255,255,255,0);
        }

            .navbar .nav li a:hover
            {
                opacity: 0.85;
                filter: alpha(opacity=85);
            }

        .navbar .nav > .active > a,
        .navbar .nav > .active > a:hover,
        .navbar .nav > .active > a:focus
        {
            opacity: 1;
            filter: alpha(opacity=100);
        }

        .navbar-default .navbar-collapse
        {
            overflow-x: hidden;
        }



        .single-portfolio .navbar .nav > .menu-portfolio > a
        {
            opacity: 1;
            filter: alpha(opacity=100);
        }

        .single-portfolio .navbar .nav > .menu-blog.active > a,
        .post-type-archive-portfolio .navbar .nav > .menu-blog.active > a
        {
            opacity: 0.65;
            filter: alpha(opacity=65);
        }

            .single-portfolio .navbar .nav > .menu-blog.active > a:hover,
            .post-type-archive-portfolio .navbar .nav > .menu-blog.active > a:hover
            {
                opacity: 0.85;
                filter: alpha(opacity=85);
            }




        /* pagine con logo nero */




        .contatti .navbar .nav li a,
        .contacts .navbar .nav li a,
        .blog .navbar .nav li a,
        .category .navbar .nav li a,
        .single-post .navbar .nav li a
        {
            color: #424b51;
        }

        .contatti .navbar .brand,
        .contacts .navbar .brand,
        .blog .navbar .brand,
        .category .navbar .brand,
        .single-post .navbar .brand
        {
            background: url(../img/rd-logo-nero.png) no-repeat;
            background-size: 100%;
        }

        .contatti .navbar .nav > .active > a,
        .contatti .navbar .nav > .active > a:hover,
        .contatti .navbar .nav > .active > a:focus,
        .contacts .navbar .nav > .active > a,
        .contacts .navbar .nav > .active > a:hover,
        .contacts .navbar .nav > .active > a:focus,
        .blog .navbar .nav > .active > a,
        .blog .navbar .nav > .active > a:hover,
        .blog .navbar .nav > .active > a:focus,
        .category .navbar .nav > .active > a,
        .category .navbar .nav > .active > a:hover,
        .category .navbar .nav > .active > a:focus,
        .single-post .navbar .nav > .active > a,
        .single-post .navbar .nav > .active > a:hover,
        .single-post .navbar .nav > .active > a:focus
        {
            color: #424b51;
        }

        /* ==========================================================================
   navbar ridotta dopo scroll
   ========================================================================== */



        .pannello-affix
        {
            width: 100%;
            -webkit-transition: all 0.1s ease-out; /* Chrome 1-25, Safari 3.2+ */
            -moz-transition: all 0.1s ease-out; /* Firefox 4-15 */
            -o-transition: all 0.1s ease-out; /* Opera 10.50–12.00 */
            transition: all 0.1s ease-out; /* Chrome 26, Firefox 16+, IE 10+, Opera 12.10+ */
            -webkit-transform-style: preserve-3d;
            -webkit-transform-style: preserve-3d;
        }

            .pannello-affix #menu-primary-navigation
            {
                -webkit-transform-style: preserve-3d;
                -webkit-transform-style: preserve-3d;
            }

            .pannello-affix.affix
            {
                z-index: 999;
                opacity: 1;
                filter: alpha(opacity=100);
                width: 100%;
                background-color: #363635;
                -webkit-box-shadow: none; /* Android 2.3+, iOS 4.0.2-4.2, Safari 3-4 */
                box-shadow: none; /* Chrome 6+, Firefox 4+, IE 9+, iOS 5+, Opera 10.50+ */
            }

                .pannello-affix.affix .navbar-inner
                {
                    margin-top: 0;
                }

        .navbar .pannello-affix.affix .nav li a
        {
            color: #fff;
        }

        .navbar .pannello-affix.affix .brand-piccolo
        {
            display: block;
            opacity: 1;
            filter: alpha(opacity=100);
        }

        .navbar .pannello-affix.affix .brand
        {
            display: none;
            opacity: 0;
            filter: alpha(opacity=0);
        }

        /* ==========================================================================
   Content, stili generici
   ========================================================================== */




        h2 a,
        h3 a,
        h4 a
        {
            color: #262f35;
        }

        pager
        {
            margin: 22px 0 44px;
        }

        h2 a:hover,
        h3 a:hover,
        h4 a:hover
        {
            color: #4f8db4;
        }

        .pager .previous > a,
        .pager .previous > span,
        .pager .next > a,
        .pager .next > span
        {
            float: none;
        }

        .sito
        {
            overflow: hidden;
        }

        .content
        {
        }

        .Web.Design,
        .App
        {
            color: #f16358;
            text-transform: uppercase;
        }

        .Grafica,
        .Graphic.Design
        {
            color: #4db07a;
            text-transform: uppercase;
        }

        .Fotografia,
        .Photography,
        .Newsletter
        {
            color: #5388aa;
            text-transform: uppercase;
        }

        h6 .sep,
        h5 .sep
        {
            color: #a8adab;
        }

        h6 span.sep:last-child,
        h5 span.sep:last-child
        {
            display: none;
        }

        .delay03
        {
            -moz-animation-delay: 0.3s;
            -o-animation-delay: 0.3s;
            animation-delay: 0.3s;
            -webkit-animation-delay: 0.3s;
        }

        .delay05
        {
            -moz-animation-delay: 0.5s;
            -o-animation-delay: 0.5s;
            animation-delay: 0.5s;
            -webkit-animation-delay: 0.5s;
        }

        .delay08
        {
            -moz-animation-delay: 0.8s;
            -o-animation-delay: 0.8s;
            animation-delay: 0.8s;
            -webkit-animation-delay: 0.8s;
        }

        .delay12
        {
            -moz-animation-delay: 1.2s;
            -o-animation-delay: 1.2s;
            animation-delay: 1.2s;
            -webkit-animation-delay: 1.2s;
        }

        .lead-link
        {
            position: absolute;
            bottom: 0;
            left: 50%;
            margin-left: -85px;
            padding: 5px 0;
            width: 170px;
            background: transparent;
            -webkit-border-radius: 4px 4px 0 0;
            -moz-border-radius: 4px 4px 0 0;
            border-radius: 4px 4px 0 0;
            text-align: center;
            color: transparent;
            text-transform: uppercase;
            font-size: 14px;
            font-weight: 700;
            letter-spacing: 1px;
            z-index: 100;
        }

            .lead-link:hover
            {
                text-decoration: none;
                color: transparent;
            }

            .lead-link .icona-freccia-giu,
            .lead-link .icona-freccia-giu:hover
            {
                color: white;
                font-size: 20px;
                text-shadow: 0px 1px 10px rgba(0,0,0,0.3);
            }

        .alert-ie7
        {
            position: fixed;
            bottom: 0;
            background: #eac85d;
            z-index: 100;
            padding: 14px;
            width: 100%;
            color: #4b4135;
            text-align: center;
        }

        .bianco
        {
            background: #fff;
            position: relative;
        }

        section
        {
            padding: 30px 0;
            background: white;
        }

            section.menopadding
            {
                padding: 20px 0;
            }

            section.grigio
            {
                background: #ebeeed;
            }

            section.blu
            {
                background: #5c91b5;
            }

            section.nopaddingtop
            {
                padding-top: 0;
            }

            section.nopaddingbottom
            {
                padding-bottom: 0;
            }

        .textaligncenter
        {
            text-align: center;
        }

        sup
        {
            text-transform: none;
            font-size: 0.6em;
            top: -1em;
        }

        section.blu h1,
        section.blu h2,
        section.blu h3,
        section.blu h4,
        section.blu p
        {
            color: white;
        }

        .centra
        {
            display: -webkit-box;
            -webkit-box-align: center;
            display: -moz-box;
            -moz-box-align: center;
            display: -ms-flexbox;
            -ms-flex-align: center;
            display: box;
            box-align: center;
        }

        .centra-questo
        {
            z-index: 1;
            position: relative;
        }

        .media
        {
            background: #fff;
            border-bottom: solid 1px #c7c9c8;
            margin-bottom: 30px;
        }

            .media a
            {
                overflow: hidden;
            }

        .media-img
        {
            overflow: hidden;
            position: relative;
            padding: 0;
        }

            .media-img .img-overlay
            {
                background: #363635;
                background: rgba(0,0,0, 0.4);
                position: absolute;
                width: 100%;
                height: 100%;
                padding-top: 50%;
                text-align: center;
                z-index: 4;
                -webkit-transition: opacity 0.3s ease-out; /* Chrome 1-25, Safari 3.2+ */
                -moz-transition: opacity 0.3s ease-out; /* Firefox 4-15 */
                -o-transition: opacity 0.3s ease-out; /* Opera 10.50–12.00 */
                transition: opacity 0.3s ease-out; /* Chrome 26, Firefox 16+, IE 10+, Opera 12.10+ */
                opacity: 0;
                visibility: hidden;
            }

        .lt-ie9 .media-img .img-overlay
        {
            filter: alpha(opacity=70);
        }

        .media .img-overlay a
        {
            display: none;
            position: relative;
            margin-top: -24px;
        }

        .media:hover .img-overlay a,
        .media .img-overlay:hover a
        {
            display: inline-block;
        }

        .media .img-overlay h3
        {
            color: #fff;
            padding-left: 10px;
            padding-right: 10px;
            margin-bottom: 25px;
            font-size: 18px;
            margin-top: -40px;
        }

        .media:hover .img-overlay,
        .media .media-img:hover .img-overlay
        {
            visibility: visible;
            opacity: 1;
            -webkit-transition: opacity 0.3s ease-out; /* Chrome 1-25, Safari 3.2+ */
            -moz-transition: opacity 0.3s ease-out; /* Firefox 4-15 */
            -o-transition: opacity 0.3s ease-out; /* Opera 10.50–12.00 */
            transition: opacity 0.3s ease-out; /* Chrome 26, Firefox 16+, IE 10+, Opera 12.10+ */
        }

        .media p
        {
            font-size: 14px;
            line-height: 19px;
        }

        .media a:hover
        {
            text-decoration: none;
        }

        .media-body
        {
            padding: 20px 30px 10px 35px;
        }

        .media div.pull-left
        {
            overflow: hidden;
            margin-right: -15px;
            margin-left: 14px;
        }

        .media div.media-img img
        {
            -webkit-transform: scale(1, 1);
            -webkit-transition-timing-function: ease-out;
            -webkit-transition-duration: 2000ms;
            -moz-transform: scale(1, 1);
            -moz-transition-timing-function: ease-out;
            -moz-transition-duration: 2000ms;
            transform: scale(1, 1);
            transition-timing-function: ease-out;
            transition-duration: 2000ms;
            width: 100%;
            height: auto;
        }

        .media:hover div.media-img img
        {
            -webkit-transform: scale(1.15, 1.15);
            -webkit-transition-timing-function: ease-out;
            -webkit-transition-duration: 1500ms;
            -moz-transform: scale(1.15, 1.15);
            -moz-transition-timing-function: ease-out;
            -moz-transition-duration: 1500ms;
            transform: scale(1.15, 1.15);
            transition-timing-function: ease-out;
            transition-duration: 1500ms;
            position: relative;
            z-index: 3;
        }

        .media .media-testo
        {
            margin-top: 20px;
            margin-right: 20px;
        }

        hr
        {
            border-top: solid 1px #b7bbbd;
        }

        section.pagina-testo-header
        {
            padding-top: 100px;
            padding-bottom: 20px;
            background: #3e7ba8 url(../img/pagina-bg.jpg) top center no-repeat;
            background-size: cover;
        }

            section.pagina-testo-header h1
            {
                color: #fff;
            }

        section.page-header
        {
            margin-top: 0;
            margin-bottom: 0;
            background-color: #424b51;
            padding: 0;
        }

        .page-header .container
        {
            height: 800px;
            text-align: center;
            color: #fff;
            margin-top: 0;
            position: relative;
        }

        .header-titolo
        {
            text-align: center;
            display: block;
            margin: 0 8%;
            margin-top: -130px;
            top: 50%;
            position: absolute;
            left: 0;
            right: 0;
        }

        .lt-ie8 .header-titolo
        {
            position: relative;
        }

        .header-titolo h1
        {
            color: #fff;
            font-size: 26px;
        }

        .header-titolo p
        {
            border-top: solid 1px #fff;
            border-top: solid 1px rgba (255, 255, 255, 0.4);
            color: #fff;
            margin: 6px auto;
            display: inline-block;
            padding: 10px 0;
        }

        .header-titolo h1
        {
            -moz-animation-delay: 0.2s;
            -o-animation-delay: 0.2s;
            animation-delay: 0.2s;
            -webkit-animation-delay: 0.2s;
        }

        .header-titolo p
        {
            -moz-animation-delay: 0.6s;
            -o-animation-delay: 0.6s;
            animation-delay: 0.6s;
            -webkit-animation-delay: 0.6s;
        }

        .btn
        {
            background: transparent;
            -webkit-transition: all 0.2s ease-out; /* Chrome 1-25, Safari 3.2+ */
            -moz-transition: all 0.1s ease-out; /* Firefox 4-15 */
            -o-transition: all 0.1s ease-out; /* Opera 10.50–12.00 */
            transition: all 0.1s ease-out; /* Chrome 26, Firefox 16+, IE 10+, Opera 12.10+ */
        }

            .btn:hover
            {
                color: #fff;
            }

        .btn-primary:hover,
        .btn-primary:focus,
        .btn-primary:active,
        .btn-primary.active,
        .open .dropdown-toggle.btn-primary
        {
            color: #424b51;
            background: #fff;
            border-color: #fff;
        }

        .form-control::-webkit-input-placeholder
        {
            color: #838886;
        }

        .form-control::-moz-placeholder
        {
            color: #676c6b;
        }

        .form-control:-ms-input-placeholder
        { /* IE10+ */
            color: #838886;
        }

        .form-control:input-placeholder
        { /* IE10+ */
            color: ##838886;
        }

        /* slider per cambiare risoluzioni responsive */



        .slider.slider-vertical
        {
            height: 140px;
            width: 20px;
            float: left;
            margin-left: 0;
            margin-top: 65px;
        }

        .res-slider-img
        {
            margin-left: -20px;
            position: relative;
            width: 100%;
            margin-bottom: -30px;
            margin-top: -10px;
            margin-top: 20px;
        }

            .res-slider-img img
            {
                position: absolute;
                display: none;
                width: 340px;
                height: auto;
            }

                .res-slider-img img.active
                {
                    position: relative;
                    display: block;
                }

        .res-lista
        {
            position: absolute;
            float: left;
            margin-top: 30px;
            left: 35px;
        }

            .res-lista div
            {
                color: #d8dddc;
                margin: 15px 0;
            }

                .res-lista div.active
                {
                    color: #5c91b5;
                }

        .slider-handle
        {
            background: #5c91b5;
            width: 16px;
            height: 16px;
            opacity: 1;
        }

        .slider.slider-vertical .slider-handle
        {
            background: #5c91b5;
            margin-left: -6px;
            -webkit-transition: all 0.3s ease-out; /* Chrome 1-25, Safari 3.2+ */
            -moz-transition: all 0.3s ease-out; /* Firefox 4-15 */
            -o-transition: all 0.3s ease-out; /* Opera 10.50–12.00 */
            transition: all 0.3s ease-out; /* Chrome 26, Firefox 16+, IE 10+, Opera 12.10+ */
        }

        .slider-selection
        {
            background: transparent;
        }

        .slider.slider-vertical .slider-track
        {
            width: 3px;
            background: #d8dddc;
            border: none;
            box-shadow: none;
            border-bottom: none;
        }

        /* ==========================================================================
   nuovo slider full width
   ========================================================================== */





        #full-width-slider
        {
            width: 100%;
            z-index: 5;
            overflow: hidden;
            height: 800px;
            height: 100vh;
        }

            #full-width-slider .rsContent
            {
                overflow: hidden;
                height: 100%;
                width: 100%;
            }

        .js #full-width-slider
        {
            background: url(../img/loading_gif.gif) center center no-repeat;
            background-size: 45px 32px;
        }

        .lt-ie10.js #full-width-slider
        {
            background: url(../img/loading_gif_low.gif) center center no-repeat;
            background-size: 45px 32px;
        }


            .js #full-width-slider.pronto,
            .lt-ie10.js #full-width-slider.pronto
            {
                background-image: none;
            }


        .js .rsSlide .car-descrizione
        {
            display: none;
        }

        .js .rsSlide.rsActiveSlide .car-descrizione
        {
            display: block;
        }

        .loader
        {
            height: 100%;
            position: fixed;
            width: 100%;
            background: #424b51;
            top: 0;
            z-index: 9999;
            background: url(../img/loading_gif.gif) center center no-repeat #424b51;
            background-size: 45px 32px;
        }

        .lt-ie10 .loader
        {
            background: url(../img/loading_gif_low.gif) center center no-repeat;
            background-size: 45px 32px;
        }

        #full-width-slider .rsOverflow
        {
            width: 100% !important;
        }

        #full-width-slider .container
        {
            position: relative;
            height: 100%;
            z-index: 10;
        }


        #full-width-slider a.rsImg
        {
            display: none;
        }

        #full-width-slider .rsImg
        {
            max-width: none;
            position: absolute;
            width: 100%;
            top: 0;
            -webkit-transform: translateZ(0);
        }

        #full-width-slider .container.desc .row
        {
            position: absolute;
            z-index: 15;
            left: 15px;
            top: auto;
            bottom: 40px;
            min-height: auto;
            width: 100%;
        }

        #full-width-slider .car-descrizione h2,
        #full-width-slider .car-descrizione p
        {
            color: white;
            margin-top: 10px;
            text-shadow: 0px 1px 10px rgba(0,0,0,0.3);
        }

        #full-width-slider .car-descrizione h6
        {
            text-shadow: 0px 1px 6px rgba(0,0,0,0.3);
        }

        #full-width-slider .car-descrizione h2
        {
            margin-top: 10px;
        }

            #full-width-slider .car-descrizione h2 a
            {
                color: white;
                -webkit-transition: all 0.2s ease-out; /* Chrome 1-25, Safari 3.2+ */
                -moz-transition: all 0.2s ease-out; /* Firefox 4-15 */
                -o-transition: all 0.2s ease-out; /* Opera 10.50–12.00 */
                transition: all 0.2s ease-out; /* Chrome 26, Firefox 16+, IE 10+, Opera 12.10+ */
            }

                #full-width-slider .car-descrizione h2 a:hover
                {
                    text-decoration: none;
                    color: rgba(255,255,255,0.70);
                }

        #full-width-slider .fs1
        {
            margin-right: 10px;
            bottom: -7px;
            display: inline-block;
            position: relative;
            font-size: 1.5em;
        }

        /***************
*
*  1. Arrows
*
****************/



        .rsArrow
        {
            height: 100%;
            width: 44px;
            position: absolute;
            display: block;
            cursor: pointer;
            z-index: 21;
        }

        .rsVer .rsArrow
        {
            width: 100%;
            height: 44px;
        }

        .rsVer .rsArrowLeft
        {
            top: 0;
            left: 0;
        }

        .rsVer .rsArrowRight
        {
            bottom: 0;
            left: 0;
        }

        .rsHor .rsArrowLeft
        {
            left: 0;
            top: 0;
        }

        .rsHor .rsArrowRight
        {
            right: 0;
            top: 0;
        }

        .rsArrowIcn
        {
            width: 32px;
            height: 32px;
            top: 50%;
            left: 50%;
            margin-top: -16px;
            margin-left: -16px;
            position: absolute;
            cursor: pointer;
            background-color: #000;
            background-color: rgba(0,0,0,0.75);
            *background-color: #000;
            border-radius: 2px;
        }

            .rsArrowIcn:hover
            {
                background-color: rgba(0,0,0,0.9);
            }

        .rsHor .rsArrowLeft .rsArrowIcn
        {
            background-position: -64px -32px;
        }

        .rsHor .rsArrowRight .rsArrowIcn
        {
            background-position: -64px -64px;
        }

        .rsVer .rsArrowLeft .rsArrowIcn
        {
            background-position: -96px -32px;
        }

        .rsVer .rsArrowRight .rsArrowIcn
        {
            background-position: -96px -64px;
        }

        .rsArrowDisabled .rsArrowIcn
        {
            opacity: .2;
            filter: alpha(opacity=20);
            *display: none;
        }

        /***************
*
*  2. Bullets
*
****************/



        .rsBullets
        {
            position: absolute;
            z-index: 35;
            left: 0;
            bottom: 20px;
            width: 100%;
            height: auto;
            margin: 0 auto;
            text-align: center;
            line-height: 8px;
            overflow: hidden;
            display: none;
        }

        .rsBullet
        {
            display: inline-block;
            *display: inline;
            *zoom: 1;
            padding: 6px 5px 6px;
        }

            .rsBullet span
            {
                display: block;
                width: 10px;
                height: 10px;
                border-radius: 50%;
                background: #777;
                background: rgba(255,255,255,0.5);
                cursor: pointer;
            }

            .rsBullet.rsNavSelected span
            {
                background-color: #FFF;
                cursor: default;
            }

        /* ==========================================================================
   HOME
   ========================================================================== */



        .home #full-width-slider .rsArrow
        {
            display: none !important;
        }

        .home #full-width-slider .rsBullets
        {
            display: block;
        }

        .home .presentazione
        {
            text-align: center;
            margin-bottom: 20px;
        }

            .home .presentazione h2
            {
                margin-top: 0;
            }

        .home .grigio .media-img img
        {
            width: 120px;
        }

        .home .grigio .media-body
        {
        }

            .home .grigio .media-body p
            {
                margin-bottom: 0;
            }

        .home .grigio
        {
            padding-bottom: 30px;
        }

        /* ==========================================================================
   ABOUT
   ========================================================================== */




        .about .header-titolo
        {
        }

        #clockanalog
        {
            background: url(../img/orologio/orologio-rd.png) no-repeat;
            width: 200px;
            height: 200px;
            margin: 0 auto 20px;
            position: relative;
        }

            #clockanalog img
            {
                border: 0;
                left: 0px;
                position: absolute;
                top: 0px;
                width: 100%;
            }

        /* inizio orologio */




        #clock
        {
            visibility: hidden;
            position: relative;
            width: 200px;
            height: 200px;
            margin: 0 auto 0 auto;
            background: url(../img/orologio/orologio-rd.png) no-repeat;
            list-style: none;
        }


        .pronto #clock
        {
            visibility: visible;
        }




        #sec,
        #min,
        #hour
        {
            position: absolute;
            width: 30px;
            height: 200px;
            top: 0px;
            left: 87px;
        }

        #sec
        {
            background: url(../img/orologio/analogseconds.png) center center no-repeat;
            z-index: 3;
            background-size: 170px;
        }

        #min
        {
            background: url(../img/orologio/analogminutes.png) center center no-repeat;
            z-index: 2;
            background-size: 170px;
        }

        #hour
        {
            background: url(../img/orologio/analoghours.png) center center no-repeat;
            z-index: 1;
            background-size: 170px;
        }

        /* 
fine orologio
 */





        .about-intro h2
        {
            margin-top: 0;
        }

        .grafico
        {
            background: white;
            text-align: center;
            padding-top: 15px;
            border-bottom: solid 1px #c7c9c8;
            margin-bottom: 30px;
        }

            .grafico canvas
            {
                margin: 10px auto;
            }

        .globale-dati
        {
            overflow: hidden;
            text-align: center;
            white-space: nowrap;
            display: table;
            width: 100%;
        }

        .globale-cont
        {
            border-right: solid 1px #fff;
            display: table-cell;
        }

            .globale-cont:last-child
            {
                border-right: none;
            }

        .globale-perc
        {
            background: #d8dddc;
            padding: 10px 0;
            font-family: "Museo500Regular", Helvetica, Arial, sans-serif;
            font-size: 30px;
            line-height: 30px;
            display: block;
            color: #51595f;
        }

        .europa .globale-perc
        {
            border-top: solid 3px #4db07a;
        }

        .asia .globale-perc
        {
            border-top: solid 3px #5c91b5;
        }

        .america .globale-perc
        {
            border-top: solid 3px #e86d4c;
        }

        .altri .globale-perc
        {
            border-top: solid 3px #eac85d;
        }

        .lt-ie8 .grafico
        {
            display: none;
        }

        #globale
        {
            width: 270px !important;
            height: 270px !important;
        }

        #visite
        {
            width: 290px !important;
            height: 157px !important;
            margin-left: -20px;
        }

        .visite-dati
        {
            background: #d8dddc;
            padding: 15px 20px;
            display: block;
            color: #51595f;
            overflow: hidden;
            margin-top: 21px;
        }

        .visite-tot
        {
            font-family: "Museo500Regular", Helvetica, Arial, sans-serif;
            font-size: 36px;
            line-height: 40px;
            text-align: center;
        }

        .visite-desc p
        {
            margin-bottom: 0;
            line-height: 20px;
        }

        .clienti-titolo
        {
            margin-top: 30px;
            text-align: center;
            margin-bottom: 30px;
        }

        .row.clienti
        {
            background: #c7c9c8;
            -webkit-border-radius: 0;
            -moz-border-radius: 0;
            border-radius: 0;
            margin: 0;
            border-bottom: solid 2px #c7c9c8;
            border-right: solid 1px #c7c9c8;
        }

        .clienti .col-md-2
        {
            padding: 0;
            border-top: solid 1px #c7c9c8;
            border-left: solid 1px #c7c9c8;
            overflow: hidden;
        }

        .pannello
        {
            float: left;
            width: 100%;
            height: auto;
            padding-bottom: 100%;
            margin: 0;
            position: relative;
            font-size: .8em;
            -webkit-perspective: 600px;
            -moz-perspective: 600px;
        }

            /* -- make sure to declare a default for every property that you want animated -- */
            /* -- general styles, including Y axis rotation -- */


            .pannello .front
            {
                float: none;
                position: absolute;
                top: 0;
                left: 0;
                padding: 0;
                z-index: 9;
                width: inherit;
                height: 100%;
                background: #fff;
                text-align: center;
                -webkit-transform: rotateX(0deg) rotateY(0deg);
                -webkit-transform-style: preserve-3d;
                -webkit-backface-visibility: hidden;
                -moz-transform: rotateX(0deg) rotateY(0deg);
                -moz-transform-style: preserve-3d;
                -moz-backface-visibility: hidden;
                /* -- transition is the magic sauce for animation -- */
                -o-transition: all .4s ease-in-out;
                -ms-transition: all .4s ease-in-out;
                -moz-transition: all .4s ease-in-out;
                -webkit-transition: all .4s ease-in-out;
                transition: all .4s ease-in-out;
                transform-style: flat;
                .;
            }

            .pannello.flip .front
            {
                z-index: 9;
                border-color: #eee;
                background: #d8dddc;
                -webkit-transform: rotateY(180deg);
                -moz-transform: rotateY(180deg);
            }

            .pannello .back
            {
                float: none;
                position: absolute;
                top: 0;
                left: 0;
                z-index: 8;
                width: inherit;
                height: 100%;
                background: #424b51;
                color: #fff;
                text-align: center;
                -webkit-transform: rotateY(-180deg);
                -webkit-transform-style: preserve-3d;
                -webkit-backface-visibility: hidden;
                -moz-transform: rotateY(-180deg);
                -moz-transform-style: preserve-3d;
                -moz-backface-visibility: hidden;
                /* -- transition is the magic sauce for animation -- */
                -o-transition: all .4s ease-in-out;
                -ms-transition: all .4s ease-in-out;
                -moz-transition: all .4s ease-in-out;
                -webkit-transition: all .4s ease-in-out;
                transition: all .4s ease-in-out;
            }

            .pannello.flip .back
            {
                z-index: 10;
                background: #5c91b5;
                -webkit-transform: rotateX(0deg) rotateY(0deg);
                -moz-transform: rotateX(0deg) rotateY(0deg);
            }

            .pannello .front .pad
            {
                width: 100%;
                height: auto;
            }

            .pannello img
            {
                width: 100%;
                height: auto;
            }

            .pannello .back h5
            {
                margin-top: 20px;
                letter-spacing: 0;
                font-size: 14px;
            }

            .pannello .back p
            {
                text-transform: uppercase;
                font-size: 12px;
                line-height: 1.1em;
            }

            .pannello.cl-tu .front
            {
                background: url(../img/avatar-placeholder.png) #eef3f7 no-repeat;
                background-size: 100% 100%;
                border: dashed 3px #c3d6e4;
                border-bottom: solid 3px #c3d6e4;
                height: 100%;
            }

            .pannello.cl-tu h3
            {
                margin-top: 36px;
            }

            .pannello.cl-tu p
            {
                font-size: 16px;
            }

        section.blu.webdev
        {
            background: url(../img/webdev-bg.png);
        }

            section.blu.webdev .row > div
            {
                position: relative;
            }

        .webdev-img
        {
            position: relative;
            max-width: 100%;
            height: auto;
        }

        #graphicdesign-img
        {
            position: relative;
            max-width: 100%;
            height: AUTO;
            margin-bottom: -30px;
            margin-top: 0;
        }

        section.foto
        {
            background: url(../img/about-photo.jpg) center center;
            background-size: cover;
            height: 450px;
            box-shadow: inset 0 0 20px rgba(0,0,0, 0.3);
            -webkit-box-shadow: inset 0 0 20px rgba(0,0,0, 0.3);
            -moz-box-shadow: inset 0 0 20px rgba(0,0,0, 0.3);
            -o-box-shadow: inset 0 0 20px rgba(0,0,0, 0.3);
        }

            section.foto .row > div
            {
                position: relative;
            }

        section.about-tre
        {
            text-align: center;
        }

        .sumisura
        {
            background: #eef3f7;
            border: dashed 3px #c3d6e4;
            padding: 20px 70px 30px;
        }

        /* ==========================================================================
   PORTFOLIO
   ========================================================================== */







        .header-titolo .icona-rd-portfolio
        {
            color: #fff;
            font-size: 140px;
            height: 140px;
            width: 140px;
            text-align: center;
            margin: 0 auto 30px;
            line-height: 140px;
        }

        .post-type-archive-portfolio .img1
        {
            height: 100px;
            width: auto;
            position: absolute;
            top: 0;
            right: 0;
            display: block;
            z-index: 10;
        }

        .post-type-archive-portfolio .img2,
        .post-type-archive-portfolio .img3
        {
            display: none;
        }



        .post-type-archive-portfolio .media
        {
            margin-top: 0;
            margin-bottom: 60px;
            position: relative;
        }

        .post-type-archive-portfolio .media-post
        {
            padding: 20px 30px;
            overflow: hidden;
        }

        .post-type-archive-portfolio .media p
        {
            font-size: inherit;
            line-height: inherit;
            margin-bottom: 0;
        }

        .post-type-archive-portfolio .media-img
        {
            padding: 0;
            height: 270px;
        }

        .blocco-portfolio
        {
            position: relative;
        }

            .blocco-portfolio a
            {
                display: block;
            }

                .blocco-portfolio a:hover
                {
                    cursor: pointer;
                }

            .blocco-portfolio .overlay
            {
                position: absolute;
                top: 0;
                width: 100%;
                background: rgba(36,39,41,0.8);
                height: 100%;
                text-align: center;
                display: -webkit-box;
                -webkit-box-align: center;
                -webkit-box-pack: center;
                display: -moz-box;
                -moz-box-align: center;
                -moz-box-pack: center;
                display: -ms-flexbox;
                -ms-flex-align: center;
                -ms-flex-pack: center;
                display: box;
                box-align: center;
                box-pack: center;
                color: #fff;
                display: none;
                -webkit-transition: all 0.3s ease-out; /* Chrome 1-25, Safari 3.2+ */
                -moz-transition: all 0.3s ease-out; /* Firefox 4-15 */
                -o-transition: all 0.3s ease-out; /* Opera 10.50–12.00 */
                transition: all 0.3s ease-out; /* Chrome 26, Firefox 16+, IE 10+, Opera 12.10+ */
            }

            .blocco-portfolio a:hover .overlay
            {
                display: block;
                display: -webkit-box;
                display: -moz-box;
                display: -ms-flexbox;
                display: box;
            }

        .single-portfolio #full-width-slider .rsBullets
        {
            display: none !important;
        }

        .single-portfolio .img1,
        .single-portfolio .img2,
        .single-portfolio .img3
        {
            height: 100px;
            width: auto;
            position: absolute;
            top: 80px;
            right: 0;
            display: block;
        }

        .single-portfolio .img2
        {
            top: 190px;
        }

        .single-portfolio .img3
        {
            top: 300px;
        }

        .portfolio-freccia
        {
            position: absolute;
            top: 50%;
            left: 20px;
            width: 46px;
            height: 46px;
            color: white;
            padding: 0;
            z-index: 20;
        }

            .portfolio-freccia a
            {
                position: relative;
                display: block;
                border: solid 1px white;
                padding: 0;
                top: 0;
                left: 0;
                -webkit-border-radius: 60px;
                -moz-border-radius: 60px;
                border-radius: 60px;
                width: 46px;
                height: 46px;
                -webkit-transition: all 0.2s ease-out; /* Chrome 1-25, Safari 3.2+ */
                -moz-transition: all 0.2s ease-out; /* Firefox 4-15 */
                -o-transition: all 0.2s ease-out; /* Opera 10.50–12.00 */
                transition: all 0.2s ease-out; /* Chrome 26, Firefox 16+, IE 10+, Opera 12.10+ */
            }

            .portfolio-freccia:hover a
            {
                width: 52px;
                height: 52px;
                top: -3px;
                left: -3px;
                padding-left: 3px;
                padding-top: 3px;
            }

            .portfolio-freccia figure
            {
                margin: 0;
                padding: 0;
                position: absolute;
                -webkit-border-radius: 300px;
                -moz-border-radius: 300px;
                border-radius: 300px;
                border: solid 2px white;
                overflow: hidden;
                bottom: 0;
                left: 50px;
                display: none;
                width: 180px;
                height: 180px;
                -webkit-box-sizing: content-box;
                -moz-box-sizing: content-box;
                box-sizing: content-box;
                background-clip: padding-box;
                display: block;
                opacity: 0;
                filter: alpha(opacity=0);
                -webkit-transition: all 0.3s ease-out; /* Chrome 1-25, Safari 3.2+ */
                -moz-transition: all 0.3s ease-out; /* Firefox 4-15 */
                -o-transition: all 0.3s ease-out; /* Opera 10.50–12.00 */
                transition: all 0.3s ease-out; /* Chrome 26, Firefox 16+, IE 10+, Opera 12.10+ */
                -webkit-transform: scale(0.6, 0.6);
                -webkit-transition-timing-function: ease-in-out;
                -webkit-transition-duration: 200ms;
                -moz-transform: scale(0.6, 0.6);
                -moz-transition-timing-function: ease-in-out;
                -moz-transition-duration: 200ms;
            }

            .portfolio-freccia:hover figure
            {
                opacity: 1;
                filter: alpha(opacity=100);
                bottom: 30px;
                -webkit-transform: scale(1, 1);
                -webkit-transition-timing-function: ease-in-out;
                -webkit-transition-duration: 200ms;
                -moz-transform: scale(1, 1);
                -moz-transition-timing-function: ease-in-out;
                -moz-transition-duration: 200ms;
            }

            .portfolio-freccia figure:hover
            {
                display: block;
            }

        .portfolio-freccia-dx figure
        {
            left: auto;
            right: 50px;
        }

        .portfolio-freccia figure img
        {
            max-width: none;
            -webkit-border-radius: 300px;
            -moz-border-radius: 300px;
            border-radius: 300px;
        }

        .portfolio-freccia a div
        {
            width: 46px;
            height: 46px;
            line-height: 46px;
            color: white;
            text-align: center;
            font-size: 24px;
            text-indent: -4px;
        }

        .portfolio-freccia:hover a
        {
            text-decoration: none;
            background: #fff;
        }

            .portfolio-freccia:hover a div
            {
                color: #424b51;
            }

        .portfolio-freccia-dx
        {
            position: absolute;
            top: 50%;
            left: auto;
            right: 20px;
        }

            .portfolio-freccia-dx a div
            {
                text-indent: 4px;
            }

        .single-portfolio #full-width-slider .container.desc .row
        {
            bottom: 20px;
        }

        .portfolio-sing-blocchi .media:first-child
        {
            margin-top: 15px;
        }

        .portfolio-sing-blocchi .media
        {
            background: transparent;
            border-bottom: none;
        }

            .portfolio-sing-blocchi .media .img-overlay a
            {
                top: auto;
            }

        /* ==========================================================================
   CONTATTI
   ========================================================================== */





        #map_canvas
        {
            min-height: 300px;
        }

        .mappa-overlay
        {
            background: #ebeeed;
            padding: 30px 0 0;
        }

            .mappa-overlay .container .form-contatti
            {
                pointer-events: all;
                background: #5388aa;
                position: relative;
                padding: 0;
            }

            .mappa-overlay .media-body
            {
                padding-top: 15px;
                ;
            }

            .mappa-overlay .media img
            {
                max-width: 132px;
            }

        .wpcf7 textarea
        {
            height: 140px;
        }

        div.wpcf7
        {
            padding: 0;
        }

        form.wpcf7-form
        {
            margin-bottom: 0;
        }

        .form-contatti-body
        {
            padding: 30px 15px 0;
        }

        .form-contatti-footer
        {
            padding: 20px 15px 20px;
            background: #477ea2;
            position: relative;
        }

        div.wpcf7 img.ajax-loader
        {
            border: none;
            vertical-align: middle;
            margin-left: 16px;
            position: absolute;
            top: 50%;
            margin-top: -10px;
            width: 24px;
            height: 24px;
        }

        div.wpcf7-response-output
        {
            margin: 0;
            padding: 15px;
            text-align: center;
        }

        div.wpcf7-validation-errors
        {
            background-color: #fcf8e3;
            border: none;
            color: #c09853;
            border-bottom: solid 1px #dfdfdf;
        }

        span.wpcf7-form-control-wrap
        {
            position: relative;
            display: block;
            margin-bottom: 12px;
        }

            span.wpcf7-form-control-wrap input,
            span.wpcf7-form-control-wrap select,
            span.wpcf7-form-control-wrap textarea
            {
                margin-bottom: 0;
            }

        span.wpcf7-not-valid-tip,
        span.wpcf7-not-valid-tip-no-ajax
        {
            position: absolute;
            top: 0;
            left: auto;
            z-index: 10;
            background: #fff;
            background: rgb(255, 74, 96);
            border: none;
            font-size: 10pt;
            width: 100%;
            padding: 2px;
            right: 0;
            height: 100%;
            line-height: 46px;
            opacity: 0.5;
            padding: 0;
            text-indent: -9999px;
            -webkit-border-radius: 3px;
            border-radius: 3px;
            overflow: hidden;
        }

        div.wpcf7-response-output
        {
            margin: 0;
            padding: 10px 15px;
        }

        div.wpcf7-mail-sent-ok
        {
            background: #48aa78;
            color: white;
            border: none;
        }

        div.wpcf7-validation-errors
        {
            border: none;
            color: inherit;
            border-bottom: solid 1px #c7c9c8;
            background: #d8dddc;
            display: block;
            color: #51595f;
        }

        .form-contatti h2
        {
            color: #fff;
            margin-top: 0;
            margin-bottom: 20px;
        }

        .bootstrap-select button,
        .bootstrap-select button:active,
        .btn-group.open .btn.dropdown-toggle
        {
            background: white;
            color: #424b51;
        }

        .form-contatti .radio input[type="radio"],
        .form-contatti .checkbox input[type="checkbox"]
        {
            position: relative;
        }

        .form-contatti .checkbox span.wpcf7-list-item
        {
            margin-left: 0;
        }

        .form-contatti .checkbox
        {
            color: #fff;
            margin-bottom: 5px;
            font-size: 14px;
            line-height: 18px;
        }

            .form-contatti .checkbox span.wpcf7-form-control-wrap
            {
                margin-bottom: 0;
            }

            .form-contatti .checkbox a
            {
                color: #fff;
                text-decoration: underline;
            }

        .contatti-numeri
        {
            background: #fff;
        }

            .contatti-numeri h2
            {
                background: #fff;
                text-align: center;
                margin-top: 0;
            }

            .contatti-numeri p
            {
                line-height: 45px;
                width: 200px;
                margin: 0 auto;
            }

                .contatti-numeri p > span
                {
                    display: block;
                }

        /* ==========================================================================
   BLOG
   ========================================================================== */





        .navbar.navbar-blog
        {
            z-index: 1;
            margin-bottom: 0;
        }

        .nav.nav-blog > li > a:hover,
        .nav > li > a:focus
        {
            background: transparent;
        }

        .navbar .nav.nav-blog li
        {
            text-align: center;
        }

        .blog-logo
        {
            padding: 90px 0 30px;
        }

        .blog-titolo
        {
            display: block;
            margin-top: 0;
        }

        .blog-titolo
        {
            margin: 0 20px;
        }

        .blog .media,
        .category .media
        {
            position: relative;
        }

        .navbar .nav-blog
        {
            border-bottom: solid 1px #c7c9c8;
        }

        body.blog,
        body.category,
        body.single-post
        {
            background: #efe7e0;
        }

        .media-post a
        {
            display: inline;
        }

        #blog-blocchi
        {
            position: relative;
            width: auto !important;
        }

            #blog-blocchi .element .media
            {
                position: relative;
            }

        .media > .pull-left
        {
            margin-right: 0;
        }

        #blog-blocchi .element .media .img-overlay
        {
            padding-top: 0;
        }

            #blog-blocchi .element .media .img-overlay a
            {
                top: 50%;
            }

        .media-post
        {
            padding: 15px 20px 15px 20px;
            overflow: hidden;
        }

            .media-post h3
            {
                margin-top: 0;
            }

        p.metadata
        {
            font-size: 13px;
            margin-bottom: 6px !important;
            color: #62696e;
        }

        .blog .media h3,
        .category .media h3
        {
            font-size: 22px;
            line-height: 26px;
            margin-bottom: 10px;
        }

        h5.blog-categorie
        {
            display: block;
            position: absolute;
            bottom: 0;
            right: 0;
            background: #424b51;
            color: white;
            padding: 3px 10px;
            margin: 0;
            text-transform: uppercase;
            font-size: 11px;
        }

            h5.blog-categorie a
            {
                color: #fff;
            }

        .blog .media h5 a,
        .category .media h5 a
        {
            display: inline;
            color: white;
        }

        .blog .media p,
        .category .media p
        {
            margin-bottom: 0;
        }

        .blog .media .media-post,
        .category .media .media-post
        {
            padding: 20px 30px 30px 30px;
        }

        .blog .media.post-featured .media-post,
        .category .media.post-featured .media-post
        {
            padding: 20px 15px 30px 15px;
        }

        .blog .post-featured.media .media-img,
        .category .post-featured.media .media-img,
        .blog .post-normale.media .media-img,
        .category .post-normale.media .media-img
        {
            max-height: 200px;
        }

        /* ==========================================================================
   BLOG - pagina articolo
   ========================================================================== */





        .single-post .main
        {
            margin: 0 -15px;
        }

            .single-post .main h1
            {
                font-size: 30px;
            }

        .single-post .attachment-post-single.wp-post-image
        {
            width: 100%;
            margin-bottom: 10px;
            height: auto;
        }

        .single-post .articolo-box
        {
            background: #fff;
            padding-bottom: 40px;
            overflow: hidden;
        }

        .single-post .entry-content
        {
            background: #fff;
        }

        .single-post .articolo-box header
        {
            margin: 20px 15px;
        }

            .single-post .articolo-box header h1
            {
                font-size: 30px;
            }

        .single-post h5.blog-categorie
        {
            position: relative;
            bottom: auto;
            right: auto;
            margin: 0 20px;
            display: inline-block;
            margin-left: 0;
            padding-left: 15px;
            margin-bottom: 10px;
        }

        .single-post .metadata
        {
            margin-bottom: 25px;
        }

        .addthis_floating_style.addthis_counter_style
        {
            width: 60px;
            position: relative;
            margin: 30px auto;
        }

        .single-post .articolo-box .entry-content img
        {
            max-width: 100%;
            height: auto;
        }

        #comments
        {
            margin-top: 30px;
            padding: 20px 30px;
        }

            #comments .media
            {
                padding: 10px 0;
                border-bottom: none;
            }

                #comments .media a
                {
                }

        .avatar
        {
            -webkit-border-radius: 50%;
            -moz-border-radius: 50%;
            border-radius: 50%;
        }

        #comments .media-body
        {
            margin: 0;
            padding: 0 20px;
        }

        #comments .media .media
        {
            border-bottom: none;
        }

        #respond
        {
            background: #5388aa;
            padding: 20px 15px 0;
            color: white;
            margin-bottom: 60px;
        }

            #respond a
            {
                color: white;
                text-decoration: underline;
            }

            #respond .respond-footer
            {
                padding: 20px 15px 20px;
                margin: 0 -15px 0 -15px;
                background: #477ea2;
                margin-top: 10px;
                margin-left: -15px;
                margin-right: -15px;
            }

        aside h3
        {
            margin-top: 0;
        }

        aside .media .media-body
        {
            padding: 10px 20px 10px 25px;
            line-height: 17px;
        }

            aside .media .media-body .metadata
            {
                margin-bottom: 0;
                font-size: 13px;
            }

            aside .media .media-body a
            {
                color: #262f35;
                margin-bottom: 4px;
                overflow: visible;
                display: block;
            }

                aside .media .media-body a:hover
                {
                    color: #4f8db4;
                }

        /* ==========================================================================
   Footer
   ========================================================================== */



        .content-info
        {
            font-size: 14px;
            line-height: 20px;
            padding: 30px 0;
            background: #fff;
            position: relative;
        }

            .content-info h5 small
            {
                color: #838886;
                margin-left: 4px;
            }

        .sottofooter
        {
            font-size: 12px;
        }

        .content-info .icone-social
        {
            width: 150px;
            margin: 0 auto 20px;
        }

        .content-info .addthis_button_facebook_like iframe
        {
            width: 120px !important;
        }

        .content-info .copyright
        {
            text-align: center;
        }

        .icone-social a
        {
            font-size: 24px;
        }

            .icone-social a:hover
            {
                text-decoration: none;
                opacity: 0.8;
            }

        a.icona-facebook
        {
            color: #2c89b6;
        }

        a.icona-twitter
        {
            color: #45ada8;
        }

        a.icona-google-plus
        {
            color: #dd4c39;
        }

        a.icona-flickr
        {
            color: #ea4c89;
        }

        a.icona-instagram
        {
            color: #aa7e62;
        }


        .language_list
        {
            list-style: none;
            text-align: center;
        }


            .language_list ul
            {
                padding: 0;
                margin: 0;
            }


            .language_list li
            {
                display: inline-block;
                margin: 0 5px;
            }
        /* ==========================================================================
   WordPress Generated Classes
   See: http://codex.wordpress.org/CSS#WordPress_Generated_Classes
   ========================================================================== */



        .aligncenter
        {
            display: block;
            margin: 0 auto;
        }

        .alignleft
        {
            float: left;
        }

        .alignright
        {
            float: right;
        }

        figure.alignnone
        {
            margin-left: 0;
            margin-right: 0;
        }



        /* ==========================================================================
   Media Queries
   ========================================================================== */




        /* fix per header su mobile, mostra sempre come fixed  */
        @media (max-width: 767px)
        {

            .pannello-affix.affix-top,
            .pannello-affix.affix
            {
                z-index: 999;
                opacity: 1;
                width: 100%;
                background-color: #363635;
                -webkit-box-shadow: none;
                box-shadow: none;
                position: fixed;
            }

                .pannello-affix.affix-top .navbar-inner,
                .pannello-affix.affix .navbar-inner
                {
                    margin-top: 0;
                }

            .navbar .brand-piccolo
            {
                display: block;
                opacity: 1;
            }

            .navbar .brand
            {
                display: none;
            }

            .navbar .nav
            {
                margin-top: 0;
            }

            .navbar-nav > li > a
            {
                padding: 10px 0 10px;
                text-align: center;
                color: #fff !important;
            }

            .navbar-collapse
            {
                box-shadow: none;
            }
        }

        @media (min-width: 768px)
        {

            /* ==========================================================================
STILI GENERICI @ 768
========================================================================== */






            h1
            {
                font-size: 40px;
            }

            h2
            {
                font-size: 32px;
            }

            h3
            {
                font-size: 26px;
            }

            h4
            {
                font-size: 19px;
            }

            h5
            {
                font-size: 16px;
            }

            h6
            {
                font-size: 13px;
            }

            p
            {
                margin-bottom: 1em;
            }


            .header-titolo
            {
                margin-left: 20%;
                margin-right: 20%;
            }

                .header-titolo h1
                {
                    font-size: 48px;
                }

            section
            {
                padding: 60px 0;
            }

                section.pagina-testo-header
                {
                    padding-top: 170px;
                    padding-bottom: 30px;
                }

            .lead-link
            {
                position: absolute;
                bottom: 0;
                left: 50%;
                margin-left: -85px;
                padding: 5px 0;
                width: 170px;
                background: white;
                color: #424b51;
            }

                .lead-link:hover
                {
                    color: #5e696f;
                }

                .lead-link .icona-freccia-giu,
                .lead-link .icona-freccia-giu:hover
                {
                    color: #424b51;
                    font-size: 14px;
                    text-shadow: none;
                }

            /* slider per cambiare risoluzioni responsive */



            .slider.slider-vertical
            {
                margin-top: 170px;
            }

            .res-slider-img
            {
                width: 100%;
                margin-bottom: -60px;
                margin-top: 80px;
            }

                .res-slider-img img
                {
                    width: 475px;
                    height: auto;
                }

            .res-lista
            {
                margin-top: 140px;
            }

            .home #full-width-slider h2
            {
                font-size: 48px;
            }

            /* ==========================================================================
   NAVBAR @ 768
   ========================================================================== */




            .banner
            {
                position: absolute;
            }

            .navbar .navbar-inner
            {
                margin-top: 80px;
            }

            .navbar .nav
            {
                float: right;
                margin-right: 0;
            }

                .navbar .nav li
                {
                    display: inline-block;
                    float: none;
                }

            .navbar-nav > li > a
            {
                padding-top: 13px;
                padding-bottom: 7px;
            }

            .navbar .nav li:last-child a
            {
                padding-right: 0;
            }

            .lt-ie8 .navbar .nav li
            {
                display: block;
                float: left;
            }

            .roll
            {
                display: inline-block;
                overflow: hidden;
                z-index: 200;
                position: relative;
                vertical-align: top;
                -webkit-transform-style: preserve-3d;
                -moz-transform-style: preserve-3d;
                -webkit-perspective: 400px;
                -moz-perspective: 400px;
                -webkit-perspective-origin: 50% 50%;
                -moz-perspective-origin: 50% 50%;
            }

                .roll span
                {
                    display: block;
                    position: relative;
                    padding: 0 2px;
                    -webkit-transition: all 400ms ease;
                    -moz-transition: all 400ms ease;
                    pointer-events: none;
                    -webkit-pointer-events: none;
                    -webkit-transform-origin: 50% 0%;
                    -moz-transform-origin: 50% 0%;
                    -webkit-transform-style: preserve-3d;
                    -moz-transform-style: preserve-3d;
                    overflow: hidden;
                }

            a.roll:hover span
            {
                overflow: visible;
                -webkit-transform: translate3d( 0px, 0px, -30px ) rotateX( 90deg );
                -moz-transform: translate3d( 0px, 0px, -30px ) rotateX( 90deg );
            }

            .roll span:after
            {
                content: attr(data-title);
                display: block;
                position: absolute;
                left: 0;
                top: 1px;
                padding: 0 2px;
                color: #424b51;
                background: #fff;
                -webkit-transform-origin: 50% 0%;
                -moz-transform-origin: 50% 0%;
                -webkit-transform: translate3d( 0px, 105%, 0px ) rotateX( -90deg );
                -moz-transform: translate3d( 0px, 105%, 0px ) rotateX( -90deg );
            }

            /* ==========================================================================
   HOME @ 768
   ========================================================================== */



            #full-width-slider .container.desc .row
            {
                bottom: 60px;
            }

            .home .car-descrizione .btn-primary
            {
                display: inline-block !important;
            }

            .home .grigio .media-body
            {
                padding: 16px 30px 10px 26px;
                margin-right: 0;
            }

            .home .grigio .media-img img
            {
                width: 100%;
            }

            .home .grigio .media-body p
            {
                margin-bottom: 0;
            }

            .home .grigio .media-body h4
            {
                font-size: 15px;
            }

            /* ==========================================================================
   ABOUT @ 768
   ========================================================================== */




            .about .header-titolo
            {
                margin-top: -300px;
            }

            .globale-perc
            {
                padding: 15px 0;
                font-size: 32px;
                line-height: 32px;
            }

            .visite-tot
            {
                font-size: 32px;
                float: left;
                width: 30%;
                text-align: center;
            }

            .visite-desc
            {
                text-align: left;
                float: left;
                width: 70%;
            }

            #globale
            {
                width: 240px !important;
                height: 240px !important;
            }

            #visite
            {
                width: 408px !important;
                height: 221px !important;
                margin-left: -20px;
            }

            .pannello .back h5
            {
                margin-top: 90px;
                font-size: 16px;
            }

            .webdev-img
            {
                bottom: -30px;
                margin-bottom: -30px;
            }

            #graphicdesign-img
            {
                margin-top: -60px;
                margin-bottom: -60px;
                max-width: 600px;
                height: 600px;
                height: auto;
                position: relative;
                right: -67px;
            }

            .pannello.cl-tu h3
            {
                margin-top: 80px;
            }

            .pannello.cl-tu p
            {
                font-size: 14px;
                padding: 0 10px;
            }

            section.foto
            {
                background-img: url(../img/about-photo.jpg);
                height: 500px;
            }

            /* ==========================================================================
   PORTFOLIO @ 768
   ========================================================================== */



            .post-type-archive-portfolio .lead-link
            {
                background: #ebeeed;
            }

            .post-type-archive-portfolio .header-titolo
            {
                margin-top: -250px;
            }

            .post-type-archive-portfolio .media-img
            {
                padding: 0;
                height: 240px;
            }

            .post-type-archive-portfolio .media-post
            {
                padding: 30px 30px;
                overflow: hidden;
            }

            .post-type-archive-portfolio .media .img-overlay a
            {
                margin-left: 15px;
            }

            .single-portfolio #full-width-slider .container.desc .row
            {
                bottom: 50px;
            }

            /* ==========================================================================
   BLOG @ 768
   ========================================================================== */




            .navbar .nav.nav-blog
            {
                float: none;
                display: table;
                width: 100%;
                z-index: 1;
            }

                .navbar .nav.nav-blog li
                {
                    display: table-cell;
                }

            .blog-logo
            {
                padding-top: 200px;
            }

            .navbar .nav-blog
            {
                margin-bottom: 25px;
            }

            #blog-blocchi .element .media.post-normale .img-overlay a
            {
                margin-left: 20px;
            }

            .blog .post-featured h3,
            .category .post-featured h3
            {
                font-size: 28px;
                margin-bottom: 10px;
            }

            .blog .post-featured.media .media-img,
            .category .post-featured.media .media-img,
            .blog .post-normale.media .media-img,
            .category .post-normale.media .media-img
            {
                max-height: none;
            }

            .single-post .main
            {
                margin: 0;
            }

            .single-post .articolo-box header
            {
                margin: 20px 30px 30px;
            }

                .single-post .articolo-box header h1
                {
                    font-size: 30px;
                }

            .single-post h5.blog-categorie
            {
                right: auto;
                padding-left: 30px;
                display: block;
                margin-right: 0;
            }

            .single-post .entry-content p
            {
                margin-bottom: 2em;
                -webkit-font-smoothing: antialiased;
            }
        }

        .single-post .entry-content p.metadata
        {
            margin-bottom: 25px !important;
        }

        .single-post .at-floatingbar-share .addthis_button_facebook_like iframe
        {
            width: 73px !important;
        }

        .single-post .entry-content
        {
            padding: 0 30px;
        }

        /* ==========================================================================
   Contatti @ 768
   ========================================================================== */









        #map_canvas,
        .mappa-overlay
        {
            top: 0;
            min-height: 800px;
        }

        #map_canvas
        {
            position: absolute !important;
        }

        .mappa-overlay
        {
            position: relative;
            top: 0;
            width: 100%;
            pointer-events: none;
            background: transparent;
        }

            .mappa-overlay > .container
            {
                width: 100%;
                padding-top: 180px;
            }

            .mappa-overlay .container .media
            {
                pointer-events: all;
                margin-top: 0;
                position: relative;
                margin-top: 100px;
            }

            .mappa-overlay .container .media-body
            {
                padding: 15px 25px 5px 25px;
            }

            .mappa-overlay .media img
            {
                max-width: none;
            }

            .mappa-overlay .container .form-contatti
            {
                margin-bottom: 150px;
            }

        .form-contatti-body
        {
            padding: 20px 20px 0;
        }

        .form-contatti-footer
        {
            padding: 10px 20px;
        }

        .contatti-numeri
        {
            pointer-events: all;
            position: absolute;
            bottom: 0;
            left: 0;
            width: 100%;
            background: #fff;
            padding: 20px 0 20px;
        }

            .contatti-numeri p
            {
                margin-bottom: 0;
                line-height: 35px;
                text-align: center;
                width: auto;
            }

                .contatti-numeri p span span
                {
                    margin-left: 25px;
                }

                .contatti-numeri p span
                {
                    display: inline;
                }

            .contatti-numeri span.mobile
            {
            }

        .contatti .content-info,
        .contacts .content-info
        {
            padding-top: 30px;
        }

        /* ==========================================================================
   Footer @ 768
   ========================================================================== */



        .content-info
        {
            padding: 60px 0;
        }

            .content-info .slogan
            {
                width: 120px;
                height: auto;
                margin-left: -20px;
                margin-top: 20px;
            }

            .content-info .icone-social
            {
                float: left;
                margin: 0;
            }

            .content-info .copyright
            {
                float: right;
                text-align: left;
            }

        }

        @media (min-width: 992px)
        {

            /* ==========================================================================
   STILI GENERICI @ 992
   ========================================================================== */




            h1
            {
                font-size: 48px;
            }

            h2
            {
                font-size: 36px;
            }

            h3
            {
                font-size: 28px;
            }

            .header-titolo
            {
                margin: 0 20%;
            }

            .media .img-overlay h3
            {
                color: #fff;
                margin-bottom: 35px;
                font-size: 24px;
            }

            /* ==========================================================================
   HOME @ 992
   ========================================================================== */




            .home .grigio .media-body
            {
                padding: 15px 30px 10px 35px;
            }

                .home .grigio .media-body h4
                {
                    font-size: 19px;
                }

            /* ==========================================================================
   ABOUT @ 992
   ========================================================================== */





            .globale-perc
            {
                font-size: 36px;
                line-height: 36px;
            }

            .visite-tot
            {
                font-size: 36px;
            }

            #globale
            {
                width: 244px !important;
                height: 244px !important;
            }

            #visite
            {
                width: 455px !important;
                height: 246px !important;
                margin-left: -20px;
            }

            .pannello .back h5
            {
                margin-top: 55px;
            }

            .pannello.cl-tu h3
            {
                margin-top: 20px;
            }

            .webdev h2
            {
                margin-top: 80px;
            }

            .webdev-img
            {
                margin-bottom: -60px;
                bottom: 0;
            }

            .graphicdesign h2
            {
                margin-top: 90px;
            }

            #graphicdesign-img
            {
                width: 670px;
                max-width: 670px;
            }

            /* ==========================================================================
   PORTFOLIO @ 992
   ========================================================================== */





            .post-type-archive-portfolio .media-img
            {
                height: 270px;
            }

            .post-type-archive-portfolio .media-post
            {
                padding: 40px 40px;
            }

            /* ==========================================================================
   BLOG @ 992
   ========================================================================== */






            .blog .media .media-post,
            .category .media .media-post
            {
                padding: 20px 30px 30px 15px;
            }

            .blog .media.post-featured .media-post,
            .category .media.post-featured .media-post
            {
                padding: 20px 20px 30px 20px;
            }

            .mappa-overlay .container .media-body
            {
                padding: 30px 30px 10px 40px;
            }

            .single-post h5.blog-categorie
            {
                padding-left: 30px;
            }

            .contatti-numeri h2
            {
                font-size: 27px;
            }

            /* ==========================================================================
   CONTATTI @ 992
   ========================================================================== */





            .contatti-numeri p
            {
                font-size: 14px;
                text-align: right;
            }

                .contatti-numeri p span span
                {
                    margin-left: 10px;
                }

            .contatti-numeri h2
            {
                text-align: left;
            }

            /* ==========================================================================
   Footer @ 992
   ========================================================================== */





            .content-info .slogan
            {
                width: 160px;
                margin-top: -20px;
            }
        }

        @media (min-width: 1200px)
        {

            /* slider per cambiare risoluzioni responsive */



            .slider.slider-vertical
            {
                margin-top: 120px;
            }

            .res-slider-img
            {
                width: 100%;
                margin-bottom: -90px;
                margin-top: -16px;
            }

                .res-slider-img img
                {
                    width: 640px;
                    height: auto;
                }

            .res-lista
            {
                margin-top: 90px;
            }

            .res-slider-cont h2
            {
                margin-top: 93px;
            }

            .content-info p
            {
                font-size: 14px;
                line-height: 20px;
            }

            .media .img-overlay h3
            {
                color: #fff;
                margin-bottom: 35px;
                font-size: 30px;
                padding-left: 5px;
                padding-right: 5px;
            }

            section
            {
                padding: 90px 0;
            }

            /* ==========================================================================
   HOME @ 1200
   ========================================================================== */



            .home .grigio
            {
                padding-bottom: 60px;
            }

                .home .grigio .media-body
                {
                    padding: 32px 30px 10px 35px;
                }

            /* ==========================================================================
   ABOUT @ 1200
   ========================================================================== */






            #globale
            {
                width: 270px !important;
                height: 270px !important;
            }

            #visite
            {
                width: 500px !important;
                height: 270px !important;
                margin-left: -20px;
            }

            .pannello.cl-tu h3
            {
                margin-top: 45px;
            }

            .pannello .back h5
            {
                margin-top: 70px;
            }

            .graphicdesign h2
            {
                margin-top: 70px;
            }

            .webdev-img
            {
                margin-bottom: -60px;
            }

            .webdev h2
            {
                margin-top: 100px;
            }

            #graphicdesign-img
            {
                width: 100%;
                max-width: 100%;
                margin-top: -90px;
                margin-bottom: -90px;
            }

            section.foto
            {
                height: 600px;
            }

            /* ==========================================================================
   PORTFOLIO @ 1200
   ========================================================================== */






            .post-type-archive-portfolio .header-titolo
            {
                margin-left: 25%;
                margin-right: 25%;
            }

            .post-type-archive-portfolio .media-img
            {
                height: 270px;
            }

            .post-type-archive-portfolio .media-post
            {
                padding: 60px 60px;
            }

            /* ==========================================================================
   CONTATTI @ 1200
   ========================================================================== */




            .form-contatti-body
            {
                padding: 20px 50px 0;
            }

            div.wpcf7-response-output
            {
                margin: 0;
                padding: 10px 50px;
            }

            .form-contatti-footer
            {
                padding: 10px 50px;
            }

            .contatti-numeri h2
            {
                font-size: 34px;
            }

            .contatti-numeri p span span.visible-lg
            {
                display: inline !important;
                margin-left: 0;
            }

            .contatti-numeri p
            {
                font-size: 16px;
                text-align: right;
            }

                .contatti-numeri p > span
                {
                    margin-left: 0;
                }

            /* ==========================================================================
   Footer @ 1200
   ========================================================================== */


            .content-info .slogan
            {
                width: 170px;
                margin-left: 0;
            }
        }


        /* immagini ad alta risoluzione */

        @media only screen and (-webkit-min-device-pixel-ratio: 2), (min-resolution: 192dpi)
        {

            .navbar .brand
            {
                background-image: url(../img/rd-logo-bianco@2x.png);
            }

            .contatti .navbar .brand,
            .contacts .navbar .brand,
            .blog .navbar .brand,
            .category .navbar .brand,
            .single-post .navbar .brand
            {
                background-image: url(../img/rd-logo-nero@2x.png);
            }
        }
    </style>

    
    </form>
</body>
</html>
                    