from twocaptcha import TwoCaptcha
from selenium import webdriver

from selenium.webdriver.chrome.options import Options
import random
from selenium.webdriver.support.ui import WebDriverWait
import time
import selenium.webdriver.support.ui as ui
import base64


def getText():
    solver = TwoCaptcha('314b37de3ee0abbe1d972b5248c83acf')

    print(solver.balance())

    result = solver.normal('./image.jpg',caseSensitive=1)
    print(result)
    time.sleep(5)
    return result
def downloadImage():
    chrome_path = '/usr/local/bin/chromedriver'
    chrome_options = Options()
    chrome_options.add_argument("user-agent=Mozilla/5.0 (Macintosh; Intel Mac OS X 12_3_1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.41 Safari/537.36")
    driver = webdriver.Chrome(executable_path=chrome_path, options=chrome_options)
    driver.get('https://www.xtremetop100.com/in.php?site=1132372650')
    
    # get the image source

    img_base64 = driver.execute_script("""
    var ele = arguments[0];
    var cnv = document.createElement('canvas');
    cnv.width = ele.width; cnv.height = ele.height;
    cnv.getContext('2d').drawImage(ele, 0, 0);
    return cnv.toDataURL('image/jpeg').substring(22);    
    """, driver.find_element_by_xpath('//*[@id="captcha"]'))
    
    with open(r"image.jpg", 'wb') as f:
        f.write(base64.b64decode(img_base64))
    input()
    result=getText()
    print(result["code"])
    ui.WebDriverWait(driver,1000).until(lambda d: d.find_element_by_xpath('//*[@id="topbanner"]/div[1]/div/form/input[3]'))
    driver.find_element_by_xpath('//*[@id="topbanner"]/div[1]/div/form/input[3]').send_keys(result["code"])
    time.sleep(2)
    ui.WebDriverWait(driver,1000).until(lambda d: d.find_element_by_xpath('//*[@id="topbanner"]/div[1]/div/form/div[1]/input'))
    driver.find_element_by_xpath('//*[@id="topbanner"]/div[1]/div/form/div[1]/input').click()
    time.sleep(10)
    driver.close()

def main():
    downloadImage()
if __name__ == '__main__':
    main()
