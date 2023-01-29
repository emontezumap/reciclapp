INSERT INTO prueba.dbo.paises
    (id,nombre,id_creador,fecha_creacion,id_modificador,fecha_modificacion,activo)
VALUES
    (N'95F064C5-AF03-49E6-9790-7C93DF1C7659', N'Venezuela', NULL, '2023-01-05 21:26:38.5066667', NULL, '2023-01-05 21:26:38.5066667', 1),
    (N'71F68C59-FD58-4679-A6E1-F72A63DEE2EF', N'México', NULL, '2023-01-05 21:28:36.3666667', NULL, '2023-01-05 21:28:36.3666667', 1);

INSERT INTO prueba.dbo.estados
    (id,nombre,id_pais,id_creador,fecha_creacion,id_modificador,fecha_modificacion,activo)
VALUES
    (N'B91D309F-8A37-4AAE-9BDB-03BC07E01121', N'Yaracuy', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 03:02:32.5957462', NULL, '2023-01-20 03:02:32.5957464', 1),
    (N'DCE0A5BA-DB25-4BBE-B86D-0AF76B0FDB05', N'Mérida', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 02:57:39.3408033', NULL, '2023-01-20 02:57:39.3408035', 1),
    (N'D66E63FA-63F1-4D4D-97F0-10F91D45225B', N'Lara', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 02:58:46.7180566', NULL, '2023-01-20 02:58:46.7180567', 1),
    (N'3D409F7B-13F7-4111-BB0F-20535665B746', N'Delta Amacuro', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 03:01:54.5744024', NULL, '2023-01-20 03:01:54.5744026', 1),
    (N'2EC9A7EA-05E8-4797-ADDC-391FD2E51453', N'Anzoátegui', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 03:11:37.2302249', NULL, '2023-01-20 03:11:37.2302971', 1),
    (N'DAA1A9F6-6162-49C8-B497-474BCE1A6DFC', N'Monagas', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 03:02:47.4174380', NULL, '2023-01-20 03:02:47.4174382', 1),
    (N'210729A4-3EC4-44CD-8EE7-5227BFDBDD1B', N'Amazonas', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 03:01:46.1618480', NULL, '2023-01-20 03:01:46.1618483', 1),
    (N'986C14DD-7736-403E-BBA3-6EDE8FCA4BFE', N'Táchira', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 03:02:20.8028564', NULL, '2023-01-20 03:02:20.8028566', 1),
    (N'7804DB68-3C44-4C93-B718-7422FCEE2719', N'Apure', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 03:02:01.0054071', NULL, '2023-01-20 03:02:01.0054073', 1),
    (N'B7421E39-025E-4B6C-87D1-76EA7302ABFD', N'Trujillo', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 03:02:27.0804199', NULL, '2023-01-20 03:02:27.0804201', 1);
INSERT INTO prueba.dbo.estados
    (id,nombre,id_pais,id_creador,fecha_creacion,id_modificador,fecha_modificacion,activo)
VALUES
    (N'63988AF0-CEA8-4909-A1C3-7AFF401B51B5', N'Carabobo', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 02:53:48.5104101', NULL, '2023-01-20 02:53:48.5104782', 1),
    (N'455046EE-89BC-4CAF-9D48-9D92CB3D7C80', N'Bolívar', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 02:59:59.6674021', NULL, '2023-01-20 02:59:59.6674023', 1),
    (N'CB398BE5-1285-40A2-830F-A89CFFBE22F0', N'Portuguesa', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 03:25:17.2984117', NULL, '2023-01-20 03:25:17.2984119', 1),
    (N'FD1DECDA-65DA-4F4C-8E23-B2F35608F1E2', N'Zulia', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 02:56:39.2391321', NULL, '2023-01-20 02:56:39.2391323', 1),
    (N'B2627ED9-87E7-4495-BD8A-B72B965A8033', N'Sucre', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 03:01:39.6265379', NULL, '2023-01-20 03:01:39.6265382', 1),
    (N'C55C8118-A33D-40CF-A455-C40FB148028E', N'Miranda', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 02:55:31.3771261', NULL, '2023-01-20 02:55:31.3771263', 1),
    (N'7EF08BE4-A2D1-435A-9713-DF90E25E3C3A', N'Falcón', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-05 21:28:09.5366667', NULL, '2023-01-05 21:28:09.5366667', 1),
    (N'DBF408B1-C7B0-443C-8CC3-E70E6D5FB3EB', N'Cojedes', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 03:25:09.2004277', NULL, '2023-01-20 03:25:09.2004279', 1),
    (N'DC0B9693-BF5F-47B4-9A28-ECAC4E22FEB0', N'Aragua', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-05 21:28:00.5033333', NULL, '2023-01-05 21:28:00.5033333', 1),
    (N'70E79E8B-3BCE-4925-B3A5-FAA2D850B937', N'Guarico', N'95F064C5-AF03-49E6-9790-7C93DF1C7659', NULL, '2023-01-20 02:59:41.2703571', NULL, '2023-01-20 02:59:41.2703573', 1);


INSERT INTO prueba.dbo.ciudades
    (id,nombre,id_estado,id_creador,fecha_creacion,id_modificador,fecha_modificacion,activo)
VALUES
    (N'2A55D016-9038-49E3-B792-0DE2E734F19F', N'Turmero', N'DC0B9693-BF5F-47B4-9A28-ECAC4E22FEB0', NULL, '2023-01-05 22:27:22.5500000', NULL, '2023-01-05 22:27:22.5500000', 1),
    (N'302F56CB-A2AF-4487-AF7F-16A9E58B68ED', N'Maracaibo', N'FD1DECDA-65DA-4F4C-8E23-B2F35608F1E2', NULL, '2023-01-20 02:57:07.5237456', NULL, '2023-01-20 02:57:07.5237458', 1),
    (N'EC5CB176-757A-4D71-B06A-3C7CA7DCADF2', N'Maracay', N'DC0B9693-BF5F-47B4-9A28-ECAC4E22FEB0', NULL, '2023-01-05 21:30:30.1033333', NULL, '2023-01-05 21:30:30.1033333', 1),
    (N'035E4030-19AD-4B04-B0AA-4D883D7A2179', N'La Victoria', N'DC0B9693-BF5F-47B4-9A28-ECAC4E22FEB0', NULL, '2023-01-18 17:31:09.6480525', NULL, '2023-01-18 17:31:09.6482229', 1),
    (N'03A06128-8882-47D7-9474-57E864538425', N'Cabimas', N'FD1DECDA-65DA-4F4C-8E23-B2F35608F1E2', NULL, '2023-01-20 02:57:12.8037771', NULL, '2023-01-20 02:57:12.8037773', 1),
    (N'EF8FA491-3E7D-49FE-9D75-63CC8462579B', N'El Vigía', N'DCE0A5BA-DB25-4BBE-B86D-0AF76B0FDB05', NULL, '2023-01-20 02:58:10.2044542', NULL, '2023-01-20 02:58:10.2044544', 1),
    (N'7183898B-2EB2-4142-ACC8-64DC1ED0AB7A', N'Judibana', N'7EF08BE4-A2D1-435A-9713-DF90E25E3C3A', NULL, '2023-01-05 22:13:30.0366667', NULL, '2023-01-05 22:13:30.0366667', 1),
    (N'F24A5845-9081-4A15-9CC5-709A9E64EB54', N'Punto Fijo', N'7EF08BE4-A2D1-435A-9713-DF90E25E3C3A', NULL, '2023-01-05 21:30:30.0533333', N'0C88F914-BE39-4DC3-AF0E-8E1524DA70D3', '2023-01-24 20:22:34.6247547', 1),
    (N'A09ECD04-B936-4CA4-8CB7-7EC776E80751', N'Barquisimeto', N'D66E63FA-63F1-4D4D-97F0-10F91D45225B', NULL, '2023-01-20 02:59:14.4893238', NULL, '2023-01-20 02:59:14.4893240', 1),
    (N'2335CE0A-5BE5-4D1A-84B9-A7A34CED33C6', N'Caracas', N'C55C8118-A33D-40CF-A455-C40FB148028E', NULL, '2023-01-20 02:55:56.2123259', NULL, '2023-01-20 02:55:56.2123261', 1);
INSERT INTO prueba.dbo.ciudades
    (id,nombre,id_estado,id_creador,fecha_creacion,id_modificador,fecha_modificacion,activo)
VALUES
    (N'85C99C4B-22EB-4627-B849-BDBD7E4E7254', N'Mérida', N'DCE0A5BA-DB25-4BBE-B86D-0AF76B0FDB05', NULL, '2023-01-20 02:58:02.3464602', NULL, '2023-01-20 02:58:02.3464603', 1),
    (N'131232AD-4212-46F7-9EC4-D10DEFB708C0', N'Valencia', N'63988AF0-CEA8-4909-A1C3-7AFF401B51B5', NULL, '2023-01-20 02:55:01.0064199', NULL, '2023-01-20 02:55:01.0064971', 1),
    (N'7A02D687-13EB-4A42-9842-E006EACEB6EA', N'Coro', N'7EF08BE4-A2D1-435A-9713-DF90E25E3C3A', N'0C88F914-BE39-4DC3-AF0E-8E1524DA70D3', '2023-01-25 23:27:26.3183561', N'0C88F914-BE39-4DC3-AF0E-8E1524DA70D3', '2023-01-25 23:27:26.3183565', 1);

INSERT INTO prueba.dbo.grupos
    (id,descripcion,es_administrador,id_creador,fecha_creacion,id_modificador,fecha_modificacion,activo)
VALUES
    (N'97CFAE57-45B6-4194-83C4-1311E3346E42', N'Administradores', 1, NULL, '2023-01-05 21:32:41.5466667', NULL, '2023-01-05 21:32:41.5466667', 1),
    (N'9C7735E8-7BA5-4E3B-B583-2494961B8209', N'Usuarios', 0, NULL, '2023-01-05 22:00:15.9400000', NULL, '2023-01-05 22:00:15.9400000', 1);

INSERT INTO prueba.dbo.profesiones
    (id,descripcion,id_creador,fecha_creacion,id_modificador,fecha_modificacion,activo)
VALUES
    (N'9C498EE3-CADD-4460-B0A4-5408551EAF8F', N'Ing. de Sistemas', NULL, '2023-01-05 22:03:03.6033333', NULL, '2023-01-05 22:03:03.6033333', 1),
    (N'5AAB56B8-B483-4BD0-A095-75D5EE408DAC', N'Ing. Químico', NULL, '2023-01-05 22:03:03.7000000', NULL, '2023-01-05 22:03:03.7000000', 1),
    (N'91D03204-01FD-4D3D-9F4F-FF90E015423A', N'Chef', NULL, '2023-01-05 22:03:03.6533333', NULL, '2023-01-05 22:03:03.6533333', 1);

INSERT INTO prueba.dbo.usuarios
    (id,nombre,segundo_nombre,apellido,segundo_apellido,direccion,id_ciudad,telefono,telefono2,email,email2,id_profesion,max_publicaciones,fecha_creacion,perfil,id_creador,id_modificador,fecha_modificacion,activo,id_grupo,clave)
VALUES
    (N'D89D3B97-6248-4CD7-9344-36F38982AC85', N'admin2', N'', N'', N'', N'', N'EC5CB176-757A-4D71-B06A-3C7CA7DCADF2', N'', N'', N'admin2api@yandex.com', N'', NULL, 0, '2023-01-07 01:32:42.1700000', N'', NULL, NULL, '2023-01-07 01:32:42.1700000', 1, N'97CFAE57-45B6-4194-83C4-1311E3346E42', N'1c142b2d01aa34e9a36bde480645a57fd69e14155dacfab5a3f9257b77fdc8d8'),
    (N'432F06C1-44B0-403B-8DB5-6446032744B9', N'Alfonzo', N'', N'Lugo', N'', N'Calle Rivas, Edf. Candy''s, Torre 2, Apto. 7-1', N'2A55D016-9038-49E3-B792-0DE2E734F19F', N'0414-4614216', N'', N'alfonzolugo@yandex.com', N'', N'5AAB56B8-B483-4BD0-A095-75D5EE408DAC', 0, '2023-01-05 22:27:51.7955604', N'', N'C7874F93-4A8E-4BA8-9BB9-B3DCAB120109', N'C7874F93-4A8E-4BA8-9BB9-B3DCAB120109', '2023-01-05 22:27:51.7955607', 1, N'9C7735E8-7BA5-4E3B-B583-2494961B8209', N'e24df920078c3dd4e7e8d2442f00e5c9ab2a231bb3918d65cc50906e49ecaef4'),
    (N'0C88F914-BE39-4DC3-AF0E-8E1524DA70D3', N'Alejandro', N'', N'Rojas', N'', N'Calle oeste 2, Nro. 113', N'7183898B-2EB2-4142-ACC8-64DC1ED0AB7A', N'0414-4614216', N'', N'aarojaslugo@yandex.com', N'', N'91D03204-01FD-4D3D-9F4F-FF90E015423A', 0, '2023-01-06 02:23:58.9500000', N'', N'C7874F93-4A8E-4BA8-9BB9-B3DCAB120109', N'C7874F93-4A8E-4BA8-9BB9-B3DCAB120109', '2023-01-06 02:23:58.9500000', 1, N'9C7735E8-7BA5-4E3B-B583-2494961B8209', N'ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f'),
    (N'C7874F93-4A8E-4BA8-9BB9-B3DCAB120109', N'admin', N'', N'', N'', N'', N'EC5CB176-757A-4D71-B06A-3C7CA7DCADF2', N'', N'', N'adminapi@yandex.com', N'', N'9C498EE3-CADD-4460-B0A4-5408551EAF8F', 0, '2023-01-05 21:33:07.7966667', N'', NULL, NULL, '2023-01-05 21:33:07.7966667', 1, N'97CFAE57-45B6-4194-83C4-1311E3346E42', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');
