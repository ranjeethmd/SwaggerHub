import React, { useState, useEffect } from 'react';
import { Sidebar } from './components/Sidebar';
import { Banner } from './components/Banner'
import SwaggerUI from 'swagger-ui';
import Config from './organization_config.json';
import '../node_modules/swagger-ui/dist/swagger-ui.css'

import './custom.css'

export const App = () => {

    const [definitionLink, setDefinitionLink] = useState("https://petstore.swagger.io/v2/swagger.json");

    const [organizationConfig] = useState(Config.orgData);

    const [definitionList, setDefinitionList] = useState();

    useEffect(() => {

        SwaggerUI({
            domNode: document.getElementById("api-data"),
            url: definitionLink
        })

    }, [definitionLink]);



    const swaggerhub = (inputMethod, inputResource, inputParams) => {
        let url = ""
        if (inputParams) {
            url = "https://api.swaggerhub.com/apis/" + inputResource + "?" + inputParams
        } else {
            url = "https://api.swaggerhub.com/apis/" + inputResource
        }

        return fetch(url, {
            method: inputMethod
        }).then(response => {
            if (response.ok) {
                return response.json()
            } throw new Error('There was an issue requesting the API')
        }).then(json => {
            return json
        })
    }

    const getOrganizationData = (organization) => {
        let inputParams = "page=0&limit=20&sort=NAME&order=ASC"
        let inputResource = organization;

        swaggerhub('GET', inputResource, inputParams).then(response => {

            setDefinitionList(response.apis);
        })
    }

    const updateDefinitionLink = (newLink) => {
        setDefinitionLink(newLink);
    }


    return (
        <>
            <Banner organizationConfig={organizationConfig} />
            <div className="App">
                <Sidebar
                    organizationConfig={organizationConfig}
                    definitionList={definitionList}
                    defaultDefinitionLink={definitionLink}
                    getOrganizationData={getOrganizationData}
                    updateDefinitionLink={updateDefinitionLink}
                />
                <div id="api-data" />
            </div>
        </>
    );

}
