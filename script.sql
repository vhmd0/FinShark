CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;
CREATE TABLE "Stocks" (
    "Id" uuid NOT NULL,
    "Symbol" character varying(10) NOT NULL,
    "CompanyName" character varying(200) NOT NULL,
    "Purchase" numeric(18,2) NOT NULL,
    "LastDiv" numeric(18,2) NOT NULL,
    "Industry" character varying(100) NOT NULL,
    "MarketCap" bigint NOT NULL,
    CONSTRAINT "PK_Stocks" PRIMARY KEY ("Id")
);

CREATE TABLE "Comments" (
    "Id" uuid NOT NULL,
    "Title" character varying(200) NOT NULL,
    "Content" character varying(2000) NOT NULL,
    "CreatedOn" timestamp with time zone NOT NULL,
    "StockId" uuid,
    CONSTRAINT "PK_Comments" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Comments_Stocks_StockId" FOREIGN KEY ("StockId") REFERENCES "Stocks" ("Id")
);

CREATE INDEX "IX_Comments_StockId" ON "Comments" ("StockId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20251012224319_Initial', '9.0.9');

COMMIT;

