DROP PROCEDURE IF EXISTS ObtainOpportunity.JXHL;
DELIMITER //
CREATE PROCEDURE ObtainOpportunity.JXHL()
BEGIN
    DECLARE XMLResult TEXT;
    DECLARE MaxAmount DECIMAL(18, 2);
    DECLARE OpportunityID INT;

    -- Obtenir la ID de l'Opportunity que ofereix més diners.
    SELECT
        OPPORTUNITY.OpportunityID,
        OPPORTUNITY.Amount
    INTO
        OpportunityID,
        MaxAmount
    FROM
        OPPORTUNITY
    GROUP BY
        OPPORTUNITY.OpportunityID
    ORDER BY
        Amount DESC
    LIMIT 1;

    -- Construir l'XML amb les dades seleccionades d'Opportunity
    SET XMLResult = CONCAT(
        '<Opportunity>',
        (SELECT
            CONCAT('<Name>', Name, '</Name>'),
            CONCAT('<Amount>', Amount, '</Amount>')
        FROM
            OPPORTUNITY
        WHERE
            OpportunityID = OpportunityID),
        '</Opportunity>'
    );

    -- Seleccionar el resultat XML
    SELECT XMLResult AS XMLResult;
END //
DELIMITER ;