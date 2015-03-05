<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/TransformObject">
    <SharedDataSet xmlns:rd="http://schemas.microsoft.com/SQLServer/reporting/reportdesigner" xmlns="http://schemas.microsoft.com/sqlserver/reporting/2010/01/shareddatasetdefinition">
      <DataSet Name="">
        <Query>
          <DataSourceReference>UTrackDatabaseDatasource</DataSourceReference>
          <DataSetParameters>
            <DataSetParameter Name="@DataSetName">
              <ReadOnly>false</ReadOnly>
              <Nullable>false</Nullable>
              <OmitFromQuery>false</OmitFromQuery>
              <rd:UserDefined>true</rd:UserDefined>
              <rd:DbType>AnsiString</rd:DbType>
            </DataSetParameter>
            <DataSetParameter Name="@QueryID">
              <ReadOnly>false</ReadOnly>
              <Nullable>false</Nullable>
              <OmitFromQuery>false</OmitFromQuery>
              <rd:UserDefined>true</rd:UserDefined>
              <rd:DbType>Int32</rd:DbType>
            </DataSetParameter>
            <DataSetParameter Name="@ScheduledReportId">
              <ReadOnly>false</ReadOnly>
              <Nullable>false</Nullable>
              <OmitFromQuery>false</OmitFromQuery>
              <rd:DbType>Int32</rd:DbType>
            </DataSetParameter>
          </DataSetParameters>
          <CommandType>StoredProcedure</CommandType>
          <CommandText>GetDataSetForReport</CommandText>
        </Query>
        <Fields>
          <xsl:for-each select="Fields/FieldDef">
            <xsl:if test="IngnoreInDataSet = 'false'">
              <xsl:variable name="FieldName">
                <xsl:value-of select="Name"  disable-output-escaping="yes"/>
              </xsl:variable>
              <Field Name="{$FieldName}">
                <DataField>
                  <xsl:value-of select="$FieldName"  disable-output-escaping="yes"/>
                </DataField>
                <rd:UserDefined>true</rd:UserDefined>
              </Field>
            </xsl:if>
          </xsl:for-each>
        </Fields>
      </DataSet>
    </SharedDataSet>
  </xsl:template>
</xsl:stylesheet>
