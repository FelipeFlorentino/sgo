INSERT INTO endereco VALUES (default, '13327-373', 'Rua Santa Clara', 186, 'Jardim Nova Era', 'Salto', 'SP');
INSERT INTO endereco VALUES (default, '13320-271', 'Rua Barão do Rio Branco', 1780, 'Vila Teixeira', 'Salto', 'SP');

INSERT INTO cliente VALUES('Felipe Florentino', '473.816.258-65', 'felipe@gmail.com', '(11) 98272-0128', 1);

INSERT INTO obra VALUES (default, '2019-01-01', null, 'Não Iniciada', 2, 'Felipe Florentino');

INSERT INTO funcionario VALUES ('037.184.257-90', 'José', 'jose@gmail.com', '(11) 98262-1433', 2500.00, 'PEDREIRO', 1, 1);

INSERT INTO etapa VALUES (default, 'Fundação', 0, 1500.00, '2019-01-01', '2019-01-31', NULL, NULL, 1);
INSERT INTO etapa VALUES (default, 'Estrutura', 0, 1500.00,'2019-02-01', '2019-02-28', NULL, NULL, 1);
INSERT INTO etapa VALUES (default, 'Paredes', 0, 1500.00,'2019-03-01', '2019-03-31', NULL, NULL, 1);
INSERT INTO etapa VALUES (default, 'Cobertura', 0, 1500.00,'2019-04-01', '2019-04-30', NULL, NULL, 1);
INSERT INTO etapa VALUES (default, 'Elétrica', 0, 1500.00,'2019-05-01', '2019-05-31', NULL, NULL, 1);
INSERT INTO etapa VALUES (default, 'Hidráulica', 0, 1500.00,'2019-06-01', '2019-06-30', NULL, NULL, 1);
INSERT INTO etapa VALUES (default, 'Forro', 0, 1500.00,'2019-07-01', '2019-07-31', NULL, NULL, 1);
INSERT INTO etapa VALUES (default, 'Revestimentos', 0, 1500.00,'2019-08-01', '2019-08-31', NULL, NULL, 1);
INSERT INTO etapa VALUES (default, 'Pisos', 0, 1500.00,'2019-09-01', '2019-09-30', NULL, NULL, 1);
INSERT INTO etapa VALUES (default, 'Pinturas', 0, 1500.00,'2019-10-01', '2019-10-31', NULL, NULL, 1);

INSERT INTO gasto VALUES (default, 'Folha de Pagamento', 'Mão de Obra', 5000.00, '2019-06-25', 1, 1);
INSERT INTO gasto VALUES (default, 'Martelo', 'Ferramenta', 200.00, '2019-06-25', 1, 1);
INSERT INTO gasto VALUES (default, 'Pisos', 'Material', 1000.00, '2019-06-25', 1, 1);
INSERT INTO gasto VALUES (default, 'Pregos', 'Material', 50.00, '2019-06-25', 1, 1);
INSERT INTO gasto VALUES (default, 'Folha de Pagamento', 'Mão de Obra', 2500.00, '2019-06-25', 1, 2);
INSERT INTO gasto VALUES (default, 'Martelo', 'Ferramenta', 500.00, '2019-06-25', 1, 2);
INSERT INTO gasto VALUES (default, 'Pisos', 'Material', 800.00, '2019-06-25', 1, 2);
INSERT INTO gasto VALUES (default, 'Pregos', 'Material', 150.00, '2019-06-25', 1, 2);

INSERT INTO gasto VALUES (default, 'Folha de Pagamento', 'Mão de Obra', 5000.00, '2019-07-25', 1, 1);
INSERT INTO gasto VALUES (default, 'Martelo', 'Ferramenta', 200.00, '2019-07-25', 1, 1);
INSERT INTO gasto VALUES (default, 'Pisos', 'Material', 1000.00, '2019-07-25', 1, 1);
INSERT INTO gasto VALUES (default, 'Pregos', 'Material', 50.00, '2019-07-25', 1, 1);
INSERT INTO gasto VALUES (default, 'Folha de Pagamento', 'Mão de Obra', 2500.00, '2019-08-25', 1, 2);
INSERT INTO gasto VALUES (default, 'Martelo', 'Ferramenta', 500.00, '2019-08-25', 1, 2);
INSERT INTO gasto VALUES (default, 'Pisos', 'Material', 800.00, '2019-09-25', 1, 2);
INSERT INTO gasto VALUES (default, 'Pregos', 'Material', 150.00, '2019-09-25', 1, 2);